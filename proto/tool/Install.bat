
: ������ʹ�õ�����GOPATH
set CURR=%cd%
cd ../../server
set GOPATH=%cd%
cd %CURR%

: windows�汾
set GOARCH=amd64
set GOOS=windows

go build -v -o sprotogen.exe github.com/davyxu/gosproto/sprotogen