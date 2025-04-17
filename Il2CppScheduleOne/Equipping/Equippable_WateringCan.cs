using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.ObjectScripts.WateringCan;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BC RID: 1468
	public class Equippable_WateringCan : Equippable_Pourable
	{
		// Token: 0x060080CE RID: 32974 RVA: 0x002265B0 File Offset: 0x002247B0
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_WateringCan()
		{
			Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr);
			Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "<InteractionLabel>k__BackingField");
			Equippable_WateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "Visuals");
			Equippable_WateringCan.NativeFieldInfoPtr_WCInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, "WCInstance");
			Equippable_WateringCan.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679447);
			Equippable_WateringCan.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679448);
			Equippable_WateringCan.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679449);
			Equippable_WateringCan.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679450);
			Equippable_WateringCan.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679451);
			Equippable_WateringCan.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679452);
			Equippable_WateringCan.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679453);
			Equippable_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr, 100679454);
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x060080CF RID: 32975 RVA: 0x002266BC File Offset: 0x002248BC
		// (set) Token: 0x060080D0 RID: 32976 RVA: 0x00226700 File Offset: 0x00224900
		public unsafe override string InteractionLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x00226750 File Offset: 0x00224950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244532, XrefRangeEnd = 244554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x002267A0 File Offset: 0x002249A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244554, XrefRangeEnd = 244566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x002267DC File Offset: 0x002249DC
		[CallerCount(0)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_WateringCan.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x00226810 File Offset: 0x00224A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244566, XrefRangeEnd = 244576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x00226884 File Offset: 0x00224A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244576, XrefRangeEnd = 244580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_WateringCan.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x002268D4 File Offset: 0x00224AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244580, XrefRangeEnd = 244585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_WateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x0003D228 File Offset: 0x0003B428
		public Equippable_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x060080D8 RID: 32984 RVA: 0x00226910 File Offset: 0x00224B10
		// (set) Token: 0x060080D9 RID: 32985 RVA: 0x0003D231 File Offset: 0x0003B431
		public new unsafe string _InteractionLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr__InteractionLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x060080DA RID: 32986 RVA: 0x00226938 File Offset: 0x00224B38
		// (set) Token: 0x060080DB RID: 32987 RVA: 0x0003D250 File Offset: 0x0003B450
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x060080DC RID: 32988 RVA: 0x00226968 File Offset: 0x00224B68
		// (set) Token: 0x060080DD RID: 32989 RVA: 0x0003D26F File Offset: 0x0003B46F
		public unsafe WateringCanInstance WCInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_WCInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_WateringCan.NativeFieldInfoPtr_WCInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057B5 RID: 22453
		private static readonly IntPtr NativeFieldInfoPtr__InteractionLabel_k__BackingField;

		// Token: 0x040057B6 RID: 22454
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040057B7 RID: 22455
		private static readonly IntPtr NativeFieldInfoPtr_WCInstance;

		// Token: 0x040057B8 RID: 22456
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractionLabel_Public_Virtual_get_String_0;

		// Token: 0x040057B9 RID: 22457
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractionLabel_Public_Virtual_set_Void_String_0;

		// Token: 0x040057BA RID: 22458
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057BB RID: 22459
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057BC RID: 22460
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x040057BD RID: 22461
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0;

		// Token: 0x040057BE RID: 22462
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0;

		// Token: 0x040057BF RID: 22463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
