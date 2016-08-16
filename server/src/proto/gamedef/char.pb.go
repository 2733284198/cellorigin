// Code generated by protoc-gen-go.
// source: char.proto
// DO NOT EDIT!

package gamedef

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

type CharModel struct {
	CharName string `protobuf:"bytes,1,opt,name=CharName,json=charName" json:"CharName,omitempty"`
	Coin     int32  `protobuf:"varint,2,opt,name=Coin,json=coin" json:"Coin,omitempty"`
	Diamond  int32  `protobuf:"varint,3,opt,name=Diamond,json=diamond" json:"Diamond,omitempty"`
}

func (m *CharModel) Reset()                    { *m = CharModel{} }
func (m *CharModel) String() string            { return proto.CompactTextString(m) }
func (*CharModel) ProtoMessage()               {}
func (*CharModel) Descriptor() ([]byte, []int) { return fileDescriptor6, []int{0} }

func init() {
	proto.RegisterType((*CharModel)(nil), "gamedef.CharModel")
}

func init() { proto.RegisterFile("char.proto", fileDescriptor6) }

var fileDescriptor6 = []byte{
	// 118 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0xe2, 0xe2, 0x4a, 0xce, 0x48, 0x2c,
	0xd2, 0x2b, 0x28, 0xca, 0x2f, 0xc9, 0x17, 0x62, 0x4f, 0x4f, 0xcc, 0x4d, 0x4d, 0x49, 0x4d, 0x53,
	0x0a, 0xe5, 0xe2, 0x74, 0x06, 0x0a, 0xfb, 0xe6, 0xa7, 0xa4, 0xe6, 0x08, 0x49, 0x71, 0x71, 0x80,
	0x38, 0x7e, 0x40, 0x39, 0x09, 0x46, 0x05, 0x46, 0x0d, 0xce, 0x20, 0x8e, 0x64, 0x28, 0x5f, 0x48,
	0x88, 0x8b, 0xc5, 0x39, 0x3f, 0x33, 0x4f, 0x82, 0x09, 0x28, 0xce, 0x1a, 0xc4, 0x92, 0x0c, 0x64,
	0x0b, 0x49, 0x70, 0xb1, 0xbb, 0x64, 0x26, 0xe6, 0xe6, 0xe7, 0xa5, 0x48, 0x30, 0x83, 0x85, 0xd9,
	0x53, 0x20, 0xdc, 0x24, 0x36, 0xb0, 0x35, 0xc6, 0x80, 0x00, 0x00, 0x00, 0xff, 0xff, 0x7c, 0x53,
	0x03, 0xbe, 0x74, 0x00, 0x00, 0x00,
}
