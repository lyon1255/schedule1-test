﻿using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x0200017C RID: 380
	public class BaseVariable : Object
	{
		// Token: 0x06001E7A RID: 7802 RVA: 0x000CF280 File Offset: 0x000CD480
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVariable()
		{
			Il2CppClassPointerStore<BaseVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "BaseVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr);
			BaseVariable.NativeFieldInfoPtr_ReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "ReplicationMode");
			BaseVariable.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Name");
			BaseVariable.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "Persistent");
			BaseVariable.NativeFieldInfoPtr_VariableMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "VariableMode");
			BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, "<Owner>k__BackingField");
			BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666748);
			BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666749);
			BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666750);
			BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666751);
			BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666752);
			BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666753);
			BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr, 100666754);
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x000CF3A0 File Offset: 0x000CD5A0
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x000CF3E0 File Offset: 0x000CD5E0
		public unsafe Player Owner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_get_Owner_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x000CF424 File Offset: 0x000CD624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107252, RefRangeEnd = 107254, XrefRangeStart = 107237, XrefRangeEnd = 107252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVariable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicationMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref persistent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVariable.NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000CF4AC File Offset: 0x000CD6AC
		[CallerCount(0)]
		public unsafe virtual Object GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000CF4F8 File Offset: 0x000CD6F8
		[CallerCount(0)]
		public unsafe virtual void SetValue(Object value, bool replicate = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x000CF554 File Offset: 0x000CD754
		[CallerCount(0)]
		public unsafe virtual void ReplicateValue(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x000CF5A4 File Offset: 0x000CD7A4
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref operation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVariable.NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0001131C File Offset: 0x0000F51C
		public BaseVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x000CF60C File Offset: 0x000CD80C
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00011325 File Offset: 0x0000F525
		public unsafe EVariableReplicationMode ReplicationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_ReplicationMode)) = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x000CF634 File Offset: 0x000CD834
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x00011340 File Offset: 0x0000F540
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x000CF65C File Offset: 0x000CD85C
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x0001135F File Offset: 0x0000F55F
		public unsafe bool Persistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x000CF684 File Offset: 0x000CD884
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x0001137A File Offset: 0x0000F57A
		public unsafe EVariableMode VariableMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr_VariableMode)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x000CF6AC File Offset: 0x000CD8AC
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x00011395 File Offset: 0x0000F595
		public unsafe Player _Owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVariable.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_ReplicationMode;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_VariableMode;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Player_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Private_set_Void_Player_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EVariableReplicationMode_Boolean_EVariableMode_Player_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_Boolean_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateValue_Public_Abstract_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCondition_Public_Virtual_New_Boolean_EConditionType_String_0;
	}
}
