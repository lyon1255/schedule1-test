using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056B RID: 1387
	public class LiquidMeth_Stored : StoredItem
	{
		// Token: 0x060079F9 RID: 31225 RVA: 0x0020D404 File Offset: 0x0020B604
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_Stored()
		{
			Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "LiquidMeth_Stored");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr);
			LiquidMeth_Stored.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, "Visuals");
			LiquidMeth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, 100678553);
			LiquidMeth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr, 100678554);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0020D470 File Offset: 0x0020B670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233455, XrefRangeEnd = 233465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_Stored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0020D4EC File Offset: 0x0020B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_Stored() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_Stored>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_Stored.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0003A156 File Offset: 0x00038356
		public LiquidMeth_Stored(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x0020D528 File Offset: 0x0020B728
		// (set) Token: 0x060079FE RID: 31230 RVA: 0x0003A15F File Offset: 0x0003835F
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Stored.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_Stored.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052F9 RID: 21241
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040052FA RID: 21242
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x040052FB RID: 21243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
