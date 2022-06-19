﻿using System;

namespace ACPILib.AML
{
	[Flags]
	public enum InterpreterArgFlags : uint
	{
		None = 0x0,
		AnyType = 0x01,
		Package = 0x02,
		Event = 0x03,
		Mutex = 0x04,
		DDBHandle = 0x05,
		Integer = 0x06,
		String = 0x07,
		Buffer = 0x08,
		BufferOrString = 0x09,
		ComputeData = 0x0A,
		ObjectReference = 0x0C,
		DeviceReference = 0x0D,
		TargetReference = 0x0F,
		SimpleTarget = 0x10,
		DataObject = 0x13,
		ComplexObject = 0x14,
		ReferenceOrString = 0x15,
		RegionOrBuffer = 0x16,
		DataReferenceObject = 0x17,
		InvalidOpCode = 0xFFFFFFFF,
		Reference = 0xB,
		StoreTarget = 0xE,
	}

	class InterpreterArgs
	{
		public static InterpreterArgFlags[] ARGI_ACCESSFIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_ACQUIRE_OP = { InterpreterArgFlags.Mutex, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_ADD_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_ALIAS_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_ARG0 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG1 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG2 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG3 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG4 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG5 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ARG6 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_BANK_FIELD_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_BIT_AND_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BIT_NAND_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BIT_NOR_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BIT_NOT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BIT_OR_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BIT_XOR_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_BREAK_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_BREAK_POINT_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_BUFFER_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_BYTE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_BYTELIST_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_COMMENT_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_CONCAT_OP = { InterpreterArgFlags.AnyType, InterpreterArgFlags.AnyType, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_CONCAT_RES_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Buffer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_COND_REF_OF_OP = { InterpreterArgFlags.ObjectReference, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_CONNECTFIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_CONTINUE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_COPY_OP = { InterpreterArgFlags.AnyType, InterpreterArgFlags.SimpleTarget };
		public static InterpreterArgFlags[] ARGI_CREATE_BIT_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_CREATE_BYTE_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_CREATE_DWORD_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_CREATE_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_CREATE_QWORD_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_CREATE_WORD_FIELD_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.Reference };
		public static InterpreterArgFlags[] ARGI_DATA_REGION_OP = { InterpreterArgFlags.String, InterpreterArgFlags.String, InterpreterArgFlags.String };
		public static InterpreterArgFlags[] ARGI_DEBUG_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_DECREMENT_OP = { InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_DEREF_OF_OP = { InterpreterArgFlags.ReferenceOrString };
		public static InterpreterArgFlags[] ARGI_DEVICE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_DIVIDE_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_DWORD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_ELSE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_EVENT_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_EXTERNAL_OP = { InterpreterArgFlags.String, InterpreterArgFlags.Integer, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_FATAL_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_FIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_FIND_SET_LEFT_BIT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_FIND_SET_RIGHT_BIT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_FROM_BCD_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_IF_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_INCREMENT_OP = { InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_INDEX_FIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_INDEX_OP = { InterpreterArgFlags.ComplexObject, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_LAND_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_LEQUAL_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.ComputeData };
		public static InterpreterArgFlags[] ARGI_LGREATER_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.ComputeData };
		public static InterpreterArgFlags[] ARGI_LGREATEREQUAL_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_LLESS_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.ComputeData };
		public static InterpreterArgFlags[] ARGI_LLESSEQUAL_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_LNOT_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_LNOTEQUAL_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_LOAD_OP = { InterpreterArgFlags.RegionOrBuffer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_LOAD_TABLE_OP = { InterpreterArgFlags.String, InterpreterArgFlags.String, InterpreterArgFlags.String, InterpreterArgFlags.String, InterpreterArgFlags.String, InterpreterArgFlags.AnyType };
		public static InterpreterArgFlags[] ARGI_LOCAL0 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL1 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL2 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL3 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL4 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL5 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL6 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOCAL7 = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_LOR_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_MATCH_OP = { InterpreterArgFlags.Package, InterpreterArgFlags.Integer, InterpreterArgFlags.ComputeData, InterpreterArgFlags.Integer, InterpreterArgFlags.ComputeData, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_METHOD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_METHODCALL_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_MID_OP = { InterpreterArgFlags.BufferOrString, InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_MOD_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_MULTIPLY_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_MUTEX_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_NAME_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_NAMEDFIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_NAMEPATH_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_NOOP_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_NOTIFY_OP = { InterpreterArgFlags.DeviceReference, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_OBJECT_TYPE_OP = { InterpreterArgFlags.AnyType };
		public static InterpreterArgFlags[] ARGI_ONE_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_ONES_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_PACKAGE_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_POWER_RES_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_PROCESSOR_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_QWORD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_REF_OF_OP = { InterpreterArgFlags.ObjectReference };
		public static InterpreterArgFlags[] ARGI_REGION_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_RELEASE_OP = { InterpreterArgFlags.Mutex };
		public static InterpreterArgFlags[] ARGI_RESERVEDFIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_RESET_OP = { InterpreterArgFlags.Event };
		public static InterpreterArgFlags[] ARGI_RETURN_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_REVISION_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_SCOPE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_SERIALFIELD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_SHIFT_LEFT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_SHIFT_RIGHT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_SIGNAL_OP = { InterpreterArgFlags.Event };
		public static InterpreterArgFlags[] ARGI_SIZE_OF_OP = { InterpreterArgFlags.DataObject };
		public static InterpreterArgFlags[] ARGI_SLEEP_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_STALL_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_STATICSTRING_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_STORE_OP = { InterpreterArgFlags.DataReferenceObject, InterpreterArgFlags.StoreTarget };
		public static InterpreterArgFlags[] ARGI_STRING_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_SUBTRACT_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_THERMAL_ZONE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_TIMER_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARGI_TO_BCD_OP = { InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_TO_BUFFER_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_TO_DEC_STR_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_TO_HEX_STR_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_TO_INTEGER_OP = { InterpreterArgFlags.ComputeData, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_TO_STRING_OP = { InterpreterArgFlags.Buffer, InterpreterArgFlags.Integer, InterpreterArgFlags.TargetReference };
		public static InterpreterArgFlags[] ARGI_UNLOAD_OP = { InterpreterArgFlags.DDBHandle };
		public static InterpreterArgFlags[] ARGI_VAR_PACKAGE_OP = { InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_WAIT_OP = { InterpreterArgFlags.Event, InterpreterArgFlags.Integer };
		public static InterpreterArgFlags[] ARGI_WHILE_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_WORD_OP = { InterpreterArgFlags.InvalidOpCode };
		public static InterpreterArgFlags[] ARGI_ZERO_OP = { InterpreterArgFlags.None };
		public static InterpreterArgFlags[] ARG_NONE = { InterpreterArgFlags.None };
	}
}