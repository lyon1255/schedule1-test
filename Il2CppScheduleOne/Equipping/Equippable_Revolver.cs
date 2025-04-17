using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C4 RID: 1476
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x060081DB RID: 33243 RVA: 0x00229644 File Offset: 0x00227844
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Revolver()
		{
			Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Revolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr);
			Equippable_Revolver.NativeFieldInfoPtr_Bullets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, "Bullets");
			Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679547);
			Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679548);
			Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679549);
			Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679550);
			Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679551);
			Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679552);
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x00229700 File Offset: 0x00227900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245499, XrefRangeEnd = 245502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x00229750 File Offset: 0x00227950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245502, XrefRangeEnd = 245505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x0022978C File Offset: 0x0022798C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245505, XrefRangeEnd = 245520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x002297C8 File Offset: 0x002279C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245520, XrefRangeEnd = 245522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x00229804 File Offset: 0x00227A04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 245525, RefRangeEnd = 245529, XrefRangeStart = 245522, XrefRangeEnd = 245525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBullets(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x00229844 File Offset: 0x00227A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Revolver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x0003DC1F File Offset: 0x0003BE1F
		public Equippable_Revolver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x00229880 File Offset: 0x00227A80
		// (set) Token: 0x060081E4 RID: 33252 RVA: 0x0003DC28 File Offset: 0x0003BE28
		public unsafe Il2CppReferenceArray<Transform> Bullets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400585A RID: 22618
		private static readonly IntPtr NativeFieldInfoPtr_Bullets;

		// Token: 0x0400585B RID: 22619
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400585C RID: 22620
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x0400585D RID: 22621
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_Void_0;

		// Token: 0x0400585E RID: 22622
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0;

		// Token: 0x0400585F RID: 22623
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0;

		// Token: 0x04005860 RID: 22624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
