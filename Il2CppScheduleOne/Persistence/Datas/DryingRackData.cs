using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000297 RID: 663
	public class DryingRackData : GridItemData
	{
		// Token: 0x060030A1 RID: 12449 RVA: 0x0010AE64 File Offset: 0x00109064
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackData()
		{
			Il2CppClassPointerStore<DryingRackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr);
			DryingRackData.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Input");
			DryingRackData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Output");
			DryingRackData.NativeFieldInfoPtr_DryingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "DryingOperations");
			DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, 100668812);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0010AEE4 File Offset: 0x001090E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130902, RefRangeEnd = 130903, XrefRangeStart = 130892, XrefRangeEnd = 130902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, Il2CppReferenceArray<DryingOperation> dryingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dryingOperations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00019E49 File Offset: 0x00018049
		public DryingRackData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0010AFB4 File Offset: 0x001091B4
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x00019E52 File Offset: 0x00018052
		public unsafe ItemSet Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x0010AFE4 File Offset: 0x001091E4
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x00019E71 File Offset: 0x00018071
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x0010B014 File Offset: 0x00109214
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x00019E90 File Offset: 0x00018090
		public unsafe Il2CppReferenceArray<DryingOperation> DryingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_Input;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr_DryingOperations;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0;
	}
}
