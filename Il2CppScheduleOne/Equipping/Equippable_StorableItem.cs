using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005C5 RID: 1477
	public class Equippable_StorableItem : Equippable
	{
		// Token: 0x060081E5 RID: 33253 RVA: 0x002298B0 File Offset: 0x00227AB0
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_StorableItem()
		{
			Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_StorableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr);
			Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "isBuildingStoredItem");
			Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "lookingAtStorageObject");
			Equippable_StorableItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "rotation");
			Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679553);
			Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679554);
			Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679555);
			Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679556);
			Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679557);
			Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679558);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x00229994 File Offset: 0x00227B94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245529, RefRangeEnd = 245534, XrefRangeStart = 245529, XrefRangeEnd = 245529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x002299D0 File Offset: 0x00227BD0
		[CallerCount(0)]
		public unsafe void CheckLookingAtStorageObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x00229A04 File Offset: 0x00227C04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 245550, RefRangeEnd = 245556, XrefRangeStart = 245534, XrefRangeEnd = 245550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081E9 RID: 33257 RVA: 0x00229A40 File Offset: 0x00227C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245556, XrefRangeEnd = 245567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081EA RID: 33258 RVA: 0x00229A7C File Offset: 0x00227C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245567, XrefRangeEnd = 245579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x00229AB8 File Offset: 0x00227CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_StorableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x0003DC47 File Offset: 0x0003BE47
		public Equippable_StorableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x060081ED RID: 33261 RVA: 0x00229AF4 File Offset: 0x00227CF4
		// (set) Token: 0x060081EE RID: 33262 RVA: 0x0003DC50 File Offset: 0x0003BE50
		public unsafe bool isBuildingStoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem)) = value;
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x060081EF RID: 33263 RVA: 0x00229B1C File Offset: 0x00227D1C
		// (set) Token: 0x060081F0 RID: 33264 RVA: 0x0003DC6B File Offset: 0x0003BE6B
		public unsafe bool lookingAtStorageObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject)) = value;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x060081F1 RID: 33265 RVA: 0x00229B44 File Offset: 0x00227D44
		// (set) Token: 0x060081F2 RID: 33266 RVA: 0x0003DC86 File Offset: 0x0003BE86
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x04005861 RID: 22625
		private static readonly IntPtr NativeFieldInfoPtr_isBuildingStoredItem;

		// Token: 0x04005862 RID: 22626
		private static readonly IntPtr NativeFieldInfoPtr_lookingAtStorageObject;

		// Token: 0x04005863 RID: 22627
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04005864 RID: 22628
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005865 RID: 22629
		private static readonly IntPtr NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0;

		// Token: 0x04005866 RID: 22630
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005867 RID: 22631
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x04005868 RID: 22632
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x04005869 RID: 22633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
