using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C6 RID: 1478
	public class Equippable_SurfaceItem : Equippable_StorableItem
	{
		// Token: 0x060081F3 RID: 33267 RVA: 0x00229B6C File Offset: 0x00227D6C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_SurfaceItem()
		{
			Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr);
			Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, "isBuilding");
			Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679559);
			Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679560);
			Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679561);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00229BEC File Offset: 0x00227DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245579, XrefRangeEnd = 245596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x00229C28 File Offset: 0x00227E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245596, XrefRangeEnd = 245603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x00229C64 File Offset: 0x00227E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x0003DCA1 File Offset: 0x0003BEA1
		public Equippable_SurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x00229CA0 File Offset: 0x00227EA0
		// (set) Token: 0x060081F9 RID: 33273 RVA: 0x0003DCAA File Offset: 0x0003BEAA
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x0400586A RID: 22634
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x0400586B RID: 22635
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400586C RID: 22636
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400586D RID: 22637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
