using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C2 RID: 1474
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		// Token: 0x0600814A RID: 33098 RVA: 0x00227C98 File Offset: 0x00225E98
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Pourable()
		{
			Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Pourable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr);
			Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_Pourable.NativeFieldInfoPtr_InteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "InteractionRange");
			Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, "PourablePrefab");
			Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679493);
			Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679494);
			Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679495);
			Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679496);
			Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679497);
			Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr, 100679498);
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600814B RID: 33099 RVA: 0x00227D7C File Offset: 0x00225F7C
		// (set) Token: 0x0600814C RID: 33100 RVA: 0x00227DC0 File Offset: 0x00225FC0
		public unsafe virtual string InteractionLabel
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x00227E10 File Offset: 0x00226010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244940, XrefRangeEnd = 244990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x00227E4C File Offset: 0x0022604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244990, XrefRangeEnd = 244994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x00227E9C File Offset: 0x0022609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244994, XrefRangeEnd = 244997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Pourable.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x00227F10 File Offset: 0x00226110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245004, RefRangeEnd = 245007, XrefRangeStart = 244997, XrefRangeEnd = 245004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Pourable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Pourable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Pourable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x0003D671 File Offset: 0x0003B871
		public Equippable_Pourable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06008152 RID: 33106 RVA: 0x00227F4C File Offset: 0x0022614C
		// (set) Token: 0x06008153 RID: 33107 RVA: 0x0003D67A File Offset: 0x0003B87A
		public unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06008154 RID: 33108 RVA: 0x00227F74 File Offset: 0x00226174
		// (set) Token: 0x06008155 RID: 33109 RVA: 0x0003D699 File Offset: 0x0003B899
		public unsafe float InteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_InteractionRange)) = value;
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x00227F9C File Offset: 0x0022619C
		// (set) Token: 0x06008157 RID: 33111 RVA: 0x0003D6B4 File Offset: 0x0003B8B4
		public unsafe Pourable PourablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Pourable.NativeFieldInfoPtr_PourablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005800 RID: 22528
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x04005801 RID: 22529
		private static readonly IntPtr NativeFieldInfoPtr_InteractionRange;

		// Token: 0x04005802 RID: 22530
		private static readonly IntPtr NativeFieldInfoPtr_PourablePrefab;

		// Token: 0x04005803 RID: 22531
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_New_get_String_0;

		// Token: 0x04005804 RID: 22532
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04005805 RID: 22533
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005806 RID: 22534
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x04005807 RID: 22535
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_Pot_byref_String_0;

		// Token: 0x04005808 RID: 22536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
