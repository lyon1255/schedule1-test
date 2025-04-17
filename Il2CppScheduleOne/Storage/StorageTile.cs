using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057A RID: 1402
	public class StorageTile : MonoBehaviour
	{
		// Token: 0x06007B6E RID: 31598 RVA: 0x0021385C File Offset: 0x00211A5C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageTile()
		{
			Il2CppClassPointerStore<StorageTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageTile>.NativeClassPtr);
			StorageTile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "x");
			StorageTile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "y");
			StorageTile.NativeFieldInfoPtr_ownerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "ownerGrid");
			StorageTile.NativeFieldInfoPtr_onOccupantChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "onOccupantChanged");
			StorageTile.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, "<occupant>k__BackingField");
			StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678777);
			StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678778);
			StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678779);
			StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678780);
			StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678781);
			StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageTile>.NativeClassPtr, 100678782);
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x00213968 File Offset: 0x00211B68
		public unsafe StorageGrid _ownerGrid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06007B70 RID: 31600 RVA: 0x002139A8 File Offset: 0x00211BA8
		// (set) Token: 0x06007B71 RID: 31601 RVA: 0x002139E8 File Offset: 0x00211BE8
		public unsafe StoredItem occupant
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x00213A2C File Offset: 0x00211C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236197, XrefRangeEnd = 236198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x00213A9C File Offset: 0x00211C9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236212, RefRangeEnd = 236215, XrefRangeStart = 236198, XrefRangeEnd = 236212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(StoredItem occ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x00213AE0 File Offset: 0x00211CE0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x0003A8DF File Offset: 0x00038ADF
		public StorageTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x06007B76 RID: 31606 RVA: 0x00213B1C File Offset: 0x00211D1C
		// (set) Token: 0x06007B77 RID: 31607 RVA: 0x0003A8E8 File Offset: 0x00038AE8
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x06007B78 RID: 31608 RVA: 0x00213B44 File Offset: 0x00211D44
		// (set) Token: 0x06007B79 RID: 31609 RVA: 0x0003A903 File Offset: 0x00038B03
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06007B7A RID: 31610 RVA: 0x00213B6C File Offset: 0x00211D6C
		// (set) Token: 0x06007B7B RID: 31611 RVA: 0x0003A91E File Offset: 0x00038B1E
		public unsafe StorageGrid ownerGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_ownerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06007B7C RID: 31612 RVA: 0x00213B9C File Offset: 0x00211D9C
		// (set) Token: 0x06007B7D RID: 31613 RVA: 0x0003A93D File Offset: 0x00038B3D
		public unsafe Action onOccupantChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr_onOccupantChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06007B7E RID: 31614 RVA: 0x00213BCC File Offset: 0x00211DCC
		// (set) Token: 0x06007B7F RID: 31615 RVA: 0x0003A95C File Offset: 0x00038B5C
		public unsafe StoredItem _occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageTile.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005410 RID: 21520
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04005411 RID: 21521
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04005412 RID: 21522
		private static readonly IntPtr NativeFieldInfoPtr_ownerGrid;

		// Token: 0x04005413 RID: 21523
		private static readonly IntPtr NativeFieldInfoPtr_onOccupantChanged;

		// Token: 0x04005414 RID: 21524
		private static readonly IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x04005415 RID: 21525
		private static readonly IntPtr NativeMethodInfoPtr_get__ownerGrid_Public_get_StorageGrid_0;

		// Token: 0x04005416 RID: 21526
		private static readonly IntPtr NativeMethodInfoPtr_get_occupant_Public_get_StoredItem_0;

		// Token: 0x04005417 RID: 21527
		private static readonly IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_StoredItem_0;

		// Token: 0x04005418 RID: 21528
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStorageTile_Public_Void_Int32_Int32_Single_StorageGrid_0;

		// Token: 0x04005419 RID: 21529
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_StoredItem_0;

		// Token: 0x0400541A RID: 21530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
