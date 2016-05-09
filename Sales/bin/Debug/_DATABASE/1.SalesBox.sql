
CREATE TABLE box_user_group(
	group_id INT IDENTITY(1,1) NOT NULL,
	group_name VARCHAR(40) NOT NULL,
	created_at DATETIME NOT NULL DEFAULT GETDATE()
)


go


ALTER TABLE box_user_group
       ADD PRIMARY KEY CLUSTERED (group_id ASC)
go

CREATE TABLE box_user(
	user_id INT IDENTITY(1,1) NOT NULL,
	user_name VARCHAR(20) UNIQUE NOT NULL,
	user_password VARCHAR(255) NOT NULL,
	user_group INT NOT NULL REFERENCES box_user_group(group_id)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	created_at DATETIME NOT NULL DEFAULT GETDATE()
)

go


ALTER TABLE box_user
       ADD PRIMARY KEY CLUSTERED (user_id ASC)
go

CREATE TABLE box_menu(
	menu_id VARCHAR(100) NOT NULL,
	menu_name VARCHAR(100) NOT NULL,
	menu_lvl INT NOT NULL,
	menu_root VARCHAR(100)
)

go


ALTER TABLE box_menu
       ADD PRIMARY KEY CLUSTERED (menu_id ASC)
go

CREATE TABLE box_role(
	group_id INT NOT NULL REFERENCES box_user_group(group_id)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	menu_id VARCHAR(100) NOT NULL REFERENCES box_menu(menu_id)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	is_actived INT NOT NULL DEFAULT 0,
	updated_at DATETIME NOT NULL DEFAULT GETDATE()

)

go

CREATE TABLE box_unit(
	unit_code varchar(100) NOT NULL,
	unit_name varchar(255) NOT NULL
)

go

ALTER TABLE box_unit
       ADD PRIMARY KEY CLUSTERED (unit_code ASC)
go

CREATE TABLE box_category(
	category_code varchar(100) NOT NULL,
	category_name varchar(255) NOT NULL
)

go

ALTER TABLE box_category
       ADD PRIMARY KEY CLUSTERED (category_code ASC)
go

CREATE TABLE box_master_item(
	item_barcode VARCHAR(255) NOT NULL,
	item_name VARCHAR(255) NOT NULL,
	category_code VARCHAR(100) REFERENCES box_category(category_code) 
								ON DELETE SET NULL
								ON UPDATE CASCADE,
	unit_code VARCHAR(100) REFERENCES box_unit(unit_code)
								ON DELETE SET NULL
								ON UPDATE CASCADE,
	item_price NUMERIC(10,2) NULL,
	item_stock_alert INT NOT NULL,
	created_at DATETIME NULL,
	updated_at DATETIME NULL,
)

go 

ALTER TABLE box_master_item
       ADD PRIMARY KEY CLUSTERED (item_barcode ASC)
go


CREATE TABLE box_master_stock(
	item_barcode VARCHAR(255) UNIQUE NOT NULL REFERENCES box_master_item(item_barcode)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	item_qty INT NOT NULL,
	created_at DATETIME NULL,
	updated_at DATETIME NULL
);

go

CREATE TABLE box_provinces(
	prov_code int NOT NULL,
	prov_name VARCHAR(255) NOT NULL
)

go

ALTER TABLE box_provinces
       ADD PRIMARY KEY CLUSTERED (prov_code ASC)
go

CREATE TABLE box_regencies(
	reg_code int NOT NULL,
	prov_code int NOT NULL REFERENCES box_provinces(prov_code),
	reg_name VARCHAR(255) NOT NULL
)

go


ALTER TABLE box_regencies
       ADD PRIMARY KEY CLUSTERED (reg_code ASC)
go

CREATE TABLE box_districts
(
	dis_code int NOT NULL,
	reg_code int NOT NULL REFERENCES box_regencies(reg_code),
	dis_name VARCHAR(255) NOT NULL
)


go

ALTER TABLE box_districts
       ADD PRIMARY KEY CLUSTERED (dis_code ASC)
go

CREATE TABLE box_villages(
	vill_code bigint NOT NULL,
	dis_code int NOT NULL REFERENCES box_districts(dis_code),
	vill_name VARCHAR(255) NOT NULL
)

go


ALTER TABLE box_villages
       ADD PRIMARY KEY CLUSTERED (vill_code ASC)
go

CREATE TABLE box_member(
	member_id BIGINT NOT NULL,
	member_name VARCHAR(255) NOT NULL,
	member_telp VARCHAR(100) NULL,
	member_address TEXT NULL,
	member_point BIGINT NOT NULL DEFAULT 0,
	prov_code INT NULL REFERENCES box_provinces(prov_code),
	reg_code INT NULL REFERENCES box_regencies(reg_code),
	dis_code INT NULL REFERENCES box_districts(dis_code),
	vill_code BIGINT NULL REFERENCES box_villages(vill_code),
	created_at DATETIME NOT NULL DEFAULT GETDATE()
)

go


ALTER TABLE box_member
       ADD PRIMARY KEY CLUSTERED (member_id ASC)
go

CREATE TABLE box_supplier(
	supplier_id VARCHAR(100) NOT NULL,
	supplier_name VARCHAR(255) NOT NULL,
	supplier_desc TEXT NULL,
	supplier_telp INT NULL,
	supplier_address TEXT NULL,
	prov_code INT NULL REFERENCES box_provinces(prov_code),
	reg_code INT NULL REFERENCES box_regencies(reg_code),
	dis_code INT NULL REFERENCES box_districts(dis_code),
	vill_code BIGINT NULL REFERENCES box_villages(vill_code)
)

go


ALTER TABLE box_supplier
       ADD PRIMARY KEY CLUSTERED (supplier_id ASC)
go

CREATE TABLE trx_inv_income(
	trx_no VARCHAR(40) NOT NULL,
	modi_id INT NOT NULL REFERENCES box_user(user_id),
	supplier_id VARCHAR(100) NULL REFERENCES box_supplier(supplier_id)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	total_amount NUMERIC(10,2) NULL DEFAULT 0,
	created_at DATETIME NOT NULL DEFAULT GETDATE(),
	is_processed INT NOT NULL DEFAULT 0
)

go 


ALTER TABLE trx_inv_income
       ADD PRIMARY KEY CLUSTERED (trx_no ASC)
go

CREATE TABLE trx_inv_income_item(
	item_no BIGINT IDENTITY(1,1) NOT NULL,
	trx_no VARCHAR(40) NOT NULL REFERENCES trx_inv_income(trx_no),
	item_barcode VARCHAR(255) NOT NULL REFERENCES box_master_item(item_barcode)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	item_qty INT NOT NULL,
	item_purchase_price NUMERIC(10,2) NOT NULL,
	is_processed INT NOT NULL DEFAULT 0
	)
	
go


ALTER TABLE trx_inv_income_item
       ADD PRIMARY KEY CLUSTERED (item_no ASC)
go

CREATE TABLE trx_payment(
	trx_no VARCHAR(40) NOT NULL,
	modi_id INT NOT NULL REFERENCES box_user(user_id),
	member_id BIGINT NULL REFERENCES box_member(member_id),
	total_amount NUMERIC(10,2) NULL DEFAULT 0,
	discount NUMERIC(10,1) NULL DEFAULT 0,
	total_pay NUMERIC(10,2) NULL DEFAULT 0,
	cash_back NUMERIC(10,2) NULL DEFAULT 0,
	created_at DATETIME NOT NULL DEFAULT GETDATE(),
	is_processed INT NOT NULL DEFAULT 0
)

go

ALTER TABLE trx_payment
       ADD PRIMARY KEY CLUSTERED (trx_no ASC)
go

CREATE TABLE trx_payment_item(
	item_no BIGINT IDENTITY(1,1) NOT NULL,
	trx_no VARCHAR(40) NOT NULL REFERENCES trx_payment(trx_no),
	item_barcode VARCHAR(255) NOT NULL REFERENCES box_master_item(item_barcode)
								ON DELETE CASCADE
								ON UPDATE CASCADE,
	item_qty INT NOT NULL,
	is_processed INT NOT NULL DEFAULT 0
)

go


ALTER TABLE trx_payment_item
       ADD PRIMARY KEY CLUSTERED (item_no ASC)
go


--ADDITIONAL TABLE--

CREATE TABLE box_inv_stock_queue(
	item_no BIGINT IDENTITY(1,1) NOT NULL,
	item_barcode VARCHAR(255) NOT NULL REFERENCES box_master_item(item_barcode)
									ON DELETE CASCADE
									ON UPDATE CASCADE,
	item_purchase_price NUMERIC(10,2) NOT NULL DEFAULT 0,
	item_qty INT NOT NULL DEFAULT 0,
	created_at DATETIME NOT NULL DEFAULT GETDATE(),
	updated_at DATETIME NULL	
)

go

ALTER TABLE box_inv_stock_queue 
		ADD PRIMARY KEY CLUSTERED (item_no ASC)
go

CREATE TABLE trx_profit(
	trx_item BIGINT IDENTITY(1,1) NOT NULL,
	trx_no VARCHAR(40) NOT NULL REFERENCES trx_payment(trx_no) 
									ON DELETE CASCADE,
	item_barcode VARCHAR(255) NOT NULL REFERENCES box_master_item(item_barcode)
									ON DELETE CASCADE
									ON UPDATE CASCADE,
	profit NUMERIC(10,2) NOT NULL DEFAULT 0,
	created_at DATETIME NOT NULL DEFAULT GETDATE()
)

ALTER TABLE trx_profit 
		ADD PRIMARY KEY CLUSTERED (trx_item ASC)
go

CREATE TABLE box_store(
	store_name VARCHAR(255) NOT NULL,
	store_address TEXT NULL,
	store_phone VARCHAR(20),
	increment_point NUMERIC(10,2),
	is_active INT NOT NULL DEFAULT 1
)	

go
