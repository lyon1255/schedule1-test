using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056D RID: 1389
	public class IStorageEntity : Il2CppObjectBase
	{
		// Token: 0x06007A0A RID: 31242 RVA: 0x0020D790 File Offset: 0x0020B990
		// Note: this type is marked as 'beforefieldinit'.
		static IStorageEntity()
		{
			Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "IStorageEntity");
			IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678560);
			IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678561);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678562);
			IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678563);
			IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678564);
			IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678565);
			IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678566);
			IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678567);
			IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678568);
			IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678569);
			IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678570);
			IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678571);
			IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, 100678572);
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x0020D8BC File Offset: 0x0020BABC
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007A0C RID: 31244 RVA: 0x0020D908 File Offset: 0x0020BB08
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr3) : null;
			}
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x0020D954 File Offset: 0x0020BB54
		[CallerCount(0)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x0020D9A0 File Offset: 0x0020BBA0
		[CallerCount(0)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr3) : null;
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0020D9EC File Offset: 0x0020BBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233480, XrefRangeEnd = 233501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItemsByID(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0020DA48 File Offset: 0x0020BC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233501, XrefRangeEnd = 233518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReserveItem(StoredItem item, Employee employee)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employee);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0020DAA8 File Offset: 0x0020BCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233518, XrefRangeEnd = 233529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DereserveItem(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0020DAF8 File Offset: 0x0020BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233529, XrefRangeEnd = 233536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsItemReserved(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x0020DB50 File Offset: 0x0020BD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233536, XrefRangeEnd = 233543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Employee WhoIsReserving(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x0020DBAC File Offset: 0x0020BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233543, XrefRangeEnd = 233573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetNonReservedItemsByPrefabID(string prefabID, Employee whosAskin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(whosAskin);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x0020DC1C File Offset: 0x0020BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233573, XrefRangeEnd = 233579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator ClearReserve(StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x0020DC78 File Offset: 0x0020BE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233579, XrefRangeEnd = 233603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryFitItem(int sizeX, int sizeY, out StorageGrid grid, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			grid = ((intPtr5 == 0) ? null : new StorageGrid(intPtr5));
			IntPtr intPtr6 = intPtr2;
			originCoordinate = ((intPtr6 == 0) ? null : new Coordinate(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x0020DD30 File Offset: 0x0020BF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233603, XrefRangeEnd = 233628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int HowManyCanFit(int sizeX, int sizeY, int limit = 2147483647)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStorageEntity.NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x0003A1BD File Offset: 0x000383BD
		public IStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005303 RID: 21251
		private static readonly IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x04005304 RID: 21252
		private static readonly IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Abstract_Virtual_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005305 RID: 21253
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Abstract_Virtual_New_List_1_StoredItem_0;

		// Token: 0x04005306 RID: 21254
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Abstract_Virtual_New_List_1_StorageGrid_0;

		// Token: 0x04005307 RID: 21255
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItemsByID_Public_Virtual_New_List_1_StoredItem_String_0;

		// Token: 0x04005308 RID: 21256
		private static readonly IntPtr NativeMethodInfoPtr_ReserveItem_Public_Virtual_New_Void_StoredItem_Employee_0;

		// Token: 0x04005309 RID: 21257
		private static readonly IntPtr NativeMethodInfoPtr_DereserveItem_Public_Virtual_New_Void_StoredItem_0;

		// Token: 0x0400530A RID: 21258
		private static readonly IntPtr NativeMethodInfoPtr_IsItemReserved_Public_Virtual_New_Boolean_StoredItem_0;

		// Token: 0x0400530B RID: 21259
		private static readonly IntPtr NativeMethodInfoPtr_WhoIsReserving_Public_Virtual_New_Employee_StoredItem_0;

		// Token: 0x0400530C RID: 21260
		private static readonly IntPtr NativeMethodInfoPtr_GetNonReservedItemsByPrefabID_Public_Virtual_New_List_1_StoredItem_String_Employee_0;

		// Token: 0x0400530D RID: 21261
		private static readonly IntPtr NativeMethodInfoPtr_ClearReserve_Public_Virtual_New_IEnumerator_StoredItem_0;

		// Token: 0x0400530E RID: 21262
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Virtual_New_Boolean_Int32_Int32_byref_StorageGrid_byref_Coordinate_byref_Single_0;

		// Token: 0x0400530F RID: 21263
		private static readonly IntPtr NativeMethodInfoPtr_HowManyCanFit_Public_Virtual_New_Int32_Int32_Int32_Int32_0;

		// Token: 0x02000AB0 RID: 2736
		[ObfuscatedName("ScheduleOne.Storage.IStorageEntity+<ClearReserve>d__12")]
		public sealed class _ClearReserve_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600D38A RID: 54154 RVA: 0x003286E8 File Offset: 0x003268E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearReserve_d__12()
			{
				Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IStorageEntity>.NativeClassPtr, "<ClearReserve>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr);
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>1__state");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>2__current");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "item");
				IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, "<>4__this");
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678573);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678574);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678575);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678576);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678577);
				IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr, 100678578);
			}

			// Token: 0x0600D38B RID: 54155 RVA: 0x003287DC File Offset: 0x003269DC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearReserve_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IStorageEntity._ClearReserve_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D38C RID: 54156 RVA: 0x00328824 File Offset: 0x00326A24
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D38D RID: 54157 RVA: 0x00328858 File Offset: 0x00326A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233468, XrefRangeEnd = 233475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700419E RID: 16798
			// (get) Token: 0x0600D38E RID: 54158 RVA: 0x00328894 File Offset: 0x00326A94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D38F RID: 54159 RVA: 0x003288D4 File Offset: 0x00326AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233475, XrefRangeEnd = 233480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700419F RID: 16799
			// (get) Token: 0x0600D390 RID: 54160 RVA: 0x00328908 File Offset: 0x00326B08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IStorageEntity._ClearReserve_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D391 RID: 54161 RVA: 0x00066FDE File Offset: 0x000651DE
			public _ClearReserve_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419A RID: 16794
			// (get) Token: 0x0600D392 RID: 54162 RVA: 0x00328948 File Offset: 0x00326B48
			// (set) Token: 0x0600D393 RID: 54163 RVA: 0x00066FE7 File Offset: 0x000651E7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700419B RID: 16795
			// (get) Token: 0x0600D394 RID: 54164 RVA: 0x00328970 File Offset: 0x00326B70
			// (set) Token: 0x0600D395 RID: 54165 RVA: 0x00067002 File Offset: 0x00065202
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419C RID: 16796
			// (get) Token: 0x0600D396 RID: 54166 RVA: 0x003289A0 File Offset: 0x00326BA0
			// (set) Token: 0x0600D397 RID: 54167 RVA: 0x00067021 File Offset: 0x00065221
			public unsafe StoredItem item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700419D RID: 16797
			// (get) Token: 0x0600D398 RID: 54168 RVA: 0x003289D0 File Offset: 0x00326BD0
			// (set) Token: 0x0600D399 RID: 54169 RVA: 0x00067040 File Offset: 0x00065240
			public unsafe IStorageEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IStorageEntity._ClearReserve_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E7B RID: 36475
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E7C RID: 36476
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E7D RID: 36477
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008E7E RID: 36478
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E7F RID: 36479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E80 RID: 36480
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E81 RID: 36481
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E82 RID: 36482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E83 RID: 36483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E84 RID: 36484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
