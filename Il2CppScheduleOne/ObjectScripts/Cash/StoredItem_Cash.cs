using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000765 RID: 1893
	public class StoredItem_Cash : StoredItem
	{
		// Token: 0x0600B3D0 RID: 46032 RVA: 0x002CCFFC File Offset: 0x002CB1FC
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_Cash()
		{
			Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "StoredItem_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr);
			StoredItem_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, "cashInstance");
			StoredItem_Cash.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, "Visuals");
			StoredItem_Cash.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100685456);
			StoredItem_Cash.NativeMethodInfoPtr_RefreshShownBills_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100685457);
			StoredItem_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100685458);
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x002CD090 File Offset: 0x002CB290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308653, XrefRangeEnd = 308676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_Cash.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x002CD10C File Offset: 0x002CB30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308676, XrefRangeEnd = 308678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownBills()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Cash.NativeMethodInfoPtr_RefreshShownBills_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x002CD140 File Offset: 0x002CB340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x00058233 File Offset: 0x00056433
		public StoredItem_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B3D5 RID: 46037 RVA: 0x002CD17C File Offset: 0x002CB37C
		// (set) Token: 0x0600B3D6 RID: 46038 RVA: 0x0005823C File Offset: 0x0005643C
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B3D7 RID: 46039 RVA: 0x002CD1AC File Offset: 0x002CB3AC
		// (set) Token: 0x0600B3D8 RID: 46040 RVA: 0x0005825B File Offset: 0x0005645B
		public unsafe CashStackVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashStackVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007943 RID: 31043
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x04007944 RID: 31044
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007945 RID: 31045
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04007946 RID: 31046
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownBills_Private_Void_0;

		// Token: 0x04007947 RID: 31047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
