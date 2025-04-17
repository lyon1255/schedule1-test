using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AC RID: 1452
	public class Product_Stored : StoredItem
	{
		// Token: 0x06007FC8 RID: 32712 RVA: 0x00223450 File Offset: 0x00221650
		// Note: this type is marked as 'beforefieldinit'.
		static Product_Stored()
		{
			Il2CppClassPointerStore<Product_Stored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "Product_Stored");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Stored>.NativeClassPtr);
			Product_Stored.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Stored>.NativeClassPtr, "Visuals");
			Product_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Stored>.NativeClassPtr, 100679341);
			Product_Stored.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Stored>.NativeClassPtr, 100679342);
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x002234BC File Offset: 0x002216BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243201, XrefRangeEnd = 243205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x00223538 File Offset: 0x00221738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product_Stored() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Stored>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Stored.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x0003C916 File Offset: 0x0003AB16
		public Product_Stored(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06007FCC RID: 32716 RVA: 0x00223574 File Offset: 0x00221774
		// (set) Token: 0x06007FCD RID: 32717 RVA: 0x0003C91F File Offset: 0x0003AB1F
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Stored.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Stored.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005714 RID: 22292
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005715 RID: 22293
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04005716 RID: 22294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
