using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200017D RID: 381
	public class BoolVariable : Variable<bool>
	{
		// Token: 0x06001E8D RID: 7821 RVA: 0x000CF6DC File Offset: 0x000CD8DC
		// Note: this type is marked as 'beforefieldinit'.
		static BoolVariable()
		{
			Il2CppClassPointerStore<BoolVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "BoolVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr);
			BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666755);
			BoolVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666756);
			BoolVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr, 100666757);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000CF748 File Offset: 0x000CD948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107254, XrefRangeEnd = 107257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner, bool value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolVariable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000CF7E0 File Offset: 0x000CD9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107257, XrefRangeEnd = 107265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDeserialize(string valueString, out bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(valueString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolVariable.NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000CF848 File Offset: 0x000CDA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107265, XrefRangeEnd = 107277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000113B4 File Offset: 0x0000F5B4
		public BoolVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_Boolean_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Virtual_Boolean_String_byref_Boolean_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_Boolean_EConditionType_String_0;
	}
}
