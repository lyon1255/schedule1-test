using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C0 RID: 1472
	public class Equippable_BuildableItem : Equippable_StorableItem
	{
		// Token: 0x06008103 RID: 33027 RVA: 0x002270F4 File Offset: 0x002252F4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_BuildableItem()
		{
			Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr);
			Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, "isBuilding");
			Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679468);
			Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679469);
			Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679470);
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00227174 File Offset: 0x00225374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244702, XrefRangeEnd = 244719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x002271B0 File Offset: 0x002253B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244719, XrefRangeEnd = 244726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x002271EC File Offset: 0x002253EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		public Equippable_BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FB RID: 9979
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x00227228 File Offset: 0x00225428
		// (set) Token: 0x06008109 RID: 33033 RVA: 0x0003D3B5 File Offset: 0x0003B5B5
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x040057D6 RID: 22486
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x040057D7 RID: 22487
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040057D8 RID: 22488
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040057D9 RID: 22489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
