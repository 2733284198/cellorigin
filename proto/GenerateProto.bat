: 服务器协议
call gen_server.bat ^
service.proto ^
game.proto ^
login.proto ^
model.proto ^
behavior.proto ^
router.proto ^
char.proto ^
tool.proto

: 客户端协议
call gen_lua.bat ^
network.proto ^
game.proto ^
client.proto ^
descriptor.proto ^
addressbook.proto ^
model.proto ^
char.proto ^
login.proto

call gen_csharp.bat ^
network.proto