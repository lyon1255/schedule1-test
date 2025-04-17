using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005BE RID: 1470
	public class Equippable_Additive : Equippable_Pourable
	{
		// Token: 0x060080E9 RID: 33001 RVA: 0x00226B88 File Offset: 0x00224D88
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Additive()
		{
			Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr);
			Equippable_Additive.NativeFieldInfoPtr_additiveDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, "additiveDef");
			Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679458);
			Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679459);
			Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679460);
			Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr, 100679461);
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x00226C1C File Offset: 0x00224E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244604, XrefRangeEnd = 244617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00226C6C File Offset: 0x00224E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244617, XrefRangeEnd = 244621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartPourTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x00226CBC File Offset: 0x00224EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244621, XrefRangeEnd = 244636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour(Pot pot, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Additive.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x00226D30 File Offset: 0x00224F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244636, XrefRangeEnd = 244637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Additive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x0003D2EC File Offset: 0x0003B4EC
		public Equippable_Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x060080EF RID: 33007 RVA: 0x00226D6C File Offset: 0x00224F6C
		// (set) Token: 0x060080F0 RID: 33008 RVA: 0x0003D2F5 File Offset: 0x0003B4F5
		public unsafe AdditiveDefinition additiveDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Additive.NativeFieldInfoPtr_additiveDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057C6 RID: 22470
		private static readonly IntPtr NativeFieldInfoPtr_additiveDef;

		// Token: 0x040057C7 RID: 22471
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040057C8 RID: 22472
		private static readonly IntPtr NativeMethodInfoPtr_StartPourTask_Protected_Virtual_Void_Pot_0;

		// Token: 0x040057C9 RID: 22473
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_Pot_byref_String_0;

		// Token: 0x040057CA RID: 22474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
