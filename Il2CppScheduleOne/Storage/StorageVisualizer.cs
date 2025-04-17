using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057C RID: 1404
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x06007B83 RID: 31619 RVA: 0x00213C50 File Offset: 0x00211E50
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizer()
		{
			Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr);
			StorageVisualizer.NativeFieldInfoPtr_StorageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "StorageGrids");
			StorageVisualizer.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "ItemContainer");
			StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "FullRefreshOnItemRemoved");
			StorageVisualizer.NativeFieldInfoPtr_itemSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "itemSlots");
			StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "totalFootprintCapacity");
			StorageVisualizer.NativeFieldInfoPtr_activeStoredItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "activeStoredItems");
			StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "BlockRefreshes");
			StorageVisualizer.NativeFieldInfoPtr_updateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "updateVisuals");
			StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678784);
			StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678785);
			StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678786);
			StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678787);
			StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678788);
			StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678789);
			StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678790);
			StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678791);
			StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678792);
			StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678793);
			StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678794);
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x00213DFC File Offset: 0x00211FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236281, XrefRangeEnd = 236285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x00213E38 File Offset: 0x00212038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236285, XrefRangeEnd = 236292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x00213E74 File Offset: 0x00212074
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 236311, RefRangeEnd = 236328, XrefRangeStart = 236292, XrefRangeEnd = 236311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot, bool update = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref update;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x00213EC4 File Offset: 0x002120C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236328, XrefRangeEnd = 236330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x00213F04 File Offset: 0x00212104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236330, XrefRangeEnd = 236480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x00213F40 File Offset: 0x00212140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236532, RefRangeEnd = 236533, XrefRangeStart = 236480, XrefRangeEnd = 236532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00213FA0 File Offset: 0x002121A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236555, RefRangeEnd = 236556, XrefRangeStart = 236533, XrefRangeEnd = 236555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x00213FF0 File Offset: 0x002121F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236593, RefRangeEnd = 236595, XrefRangeStart = 236556, XrefRangeEnd = 236593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x00214030 File Offset: 0x00212230
		[CallerCount(0)]
		public unsafe void QueueRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x00214064 File Offset: 0x00212264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x002140A0 File Offset: 0x002122A0
		[CallerCount(0)]
		public unsafe void _AddSlot_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x0003A9BD File Offset: 0x00038BBD
		public StorageVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06007B90 RID: 31632 RVA: 0x002140D4 File Offset: 0x002122D4
		// (set) Token: 0x06007B91 RID: 31633 RVA: 0x0003A9C6 File Offset: 0x00038BC6
		public unsafe Il2CppReferenceArray<StorageGrid> StorageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x00214104 File Offset: 0x00212304
		// (set) Token: 0x06007B93 RID: 31635 RVA: 0x0003A9E5 File Offset: 0x00038BE5
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x00214134 File Offset: 0x00212334
		// (set) Token: 0x06007B95 RID: 31637 RVA: 0x0003AA04 File Offset: 0x00038C04
		public unsafe bool FullRefreshOnItemRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved)) = value;
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x06007B96 RID: 31638 RVA: 0x0021415C File Offset: 0x0021235C
		// (set) Token: 0x06007B97 RID: 31639 RVA: 0x0003AA1F File Offset: 0x00038C1F
		public unsafe List<ItemSlot> itemSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06007B98 RID: 31640 RVA: 0x0021418C File Offset: 0x0021238C
		// (set) Token: 0x06007B99 RID: 31641 RVA: 0x0003AA3E File Offset: 0x00038C3E
		public unsafe int totalFootprintCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity)) = value;
			}
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06007B9A RID: 31642 RVA: 0x002141B4 File Offset: 0x002123B4
		// (set) Token: 0x06007B9B RID: 31643 RVA: 0x0003AA59 File Offset: 0x00038C59
		public unsafe Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, List<StoredItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06007B9C RID: 31644 RVA: 0x002141E4 File Offset: 0x002123E4
		// (set) Token: 0x06007B9D RID: 31645 RVA: 0x0003AA78 File Offset: 0x00038C78
		public unsafe bool BlockRefreshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes)) = value;
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x0021420C File Offset: 0x0021240C
		// (set) Token: 0x06007B9F RID: 31647 RVA: 0x0003AA93 File Offset: 0x00038C93
		public unsafe bool updateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_updateVisuals)) = value;
			}
		}

		// Token: 0x0400541C RID: 21532
		private static readonly IntPtr NativeFieldInfoPtr_StorageGrids;

		// Token: 0x0400541D RID: 21533
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x0400541E RID: 21534
		private static readonly IntPtr NativeFieldInfoPtr_FullRefreshOnItemRemoved;

		// Token: 0x0400541F RID: 21535
		private static readonly IntPtr NativeFieldInfoPtr_itemSlots;

		// Token: 0x04005420 RID: 21536
		private static readonly IntPtr NativeFieldInfoPtr_totalFootprintCapacity;

		// Token: 0x04005421 RID: 21537
		private static readonly IntPtr NativeFieldInfoPtr_activeStoredItems;

		// Token: 0x04005422 RID: 21538
		private static readonly IntPtr NativeFieldInfoPtr_BlockRefreshes;

		// Token: 0x04005423 RID: 21539
		private static readonly IntPtr NativeFieldInfoPtr_updateVisuals;

		// Token: 0x04005424 RID: 21540
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005425 RID: 21541
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04005426 RID: 21542
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0;

		// Token: 0x04005427 RID: 21543
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x04005428 RID: 21544
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0;

		// Token: 0x04005429 RID: 21545
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0;

		// Token: 0x0400542A RID: 21546
		private static readonly IntPtr NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0;

		// Token: 0x0400542B RID: 21547
		private static readonly IntPtr NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x0400542C RID: 21548
		private static readonly IntPtr NativeMethodInfoPtr_QueueRefresh_Protected_Void_0;

		// Token: 0x0400542D RID: 21549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400542E RID: 21550
		private static readonly IntPtr NativeMethodInfoPtr__AddSlot_b__10_0_Private_Void_0;
	}
}
