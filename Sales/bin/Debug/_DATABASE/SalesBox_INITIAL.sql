EXEC SP_NEW_GROUP 'Administrator'

go

INSERT INTO box_user (user_name,user_password,user_group) VALUES ('admin','TCqG3CmejUs=',1);

go

UPDATE box_role SET is_actived=1 WHERE group_id=1

go