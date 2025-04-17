﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000180 RID: 384
	public class NumberVariable : Variable<float>
	{
		// Token: 0x06001EA6 RID: 7846 RVA: 0x000CFBC8 File Offset: 0x000CDDC8
		// Note: this type is marked as 'beforefieldinit'.
		static NumberVariable()
		{
			Il2CppClassPointerStore<NumberVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "NumberVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberVariable>.NativeClassPtr);
			NumberVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberVariable>.NativeClassPtr, 100666762);
			NumberVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberVariable>.NativeClassPtr, 100666763);
			NumberVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberVariable>.NativeClassPtr, 100666764);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x000CFC34 File Offset: 0x000CDE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107316, XrefRangeEnd = 107319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberVariable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000CFCCC File Offset: 0x000CDECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107319, XrefRangeEnd = 107320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDeserialize(string valueString, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(valueString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000CFD34 File Offset: 0x000CDF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107320, XrefRangeEnd = 107332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NumberVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00011481 File Offset: 0x0000F681
		public NumberVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Single_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Single_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0;
	}
}
