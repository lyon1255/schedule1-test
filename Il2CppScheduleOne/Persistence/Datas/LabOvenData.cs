using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029A RID: 666
	public class LabOvenData : GridItemData
	{
		// Token: 0x060030B8 RID: 12472 RVA: 0x0010B300 File Offset: 0x00109500
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenData()
		{
			Il2CppClassPointerStore<LabOvenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr);
			LabOvenData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "InputContents");
			LabOvenData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "OutputContents");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientID");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuantity");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuality");
			LabOvenData.NativeFieldInfoPtr_CurrentProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentProductID");
			LabOvenData.NativeFieldInfoPtr_CurrentCookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentCookProgress");
			LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, 100668815);
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0010B3D0 File Offset: 0x001095D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130929, RefRangeEnd = 130930, XrefRangeStart = 130919, XrefRangeEnd = 130929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContents);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIngredientQuantity;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentCookProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00019F35 File Offset: 0x00018135
		public LabOvenData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0010B4E4 File Offset: 0x001096E4
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x00019F3E File Offset: 0x0001813E
		public unsafe ItemSet InputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0010B514 File Offset: 0x00109714
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x00019F5D File Offset: 0x0001815D
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0010B544 File Offset: 0x00109744
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x00019F7C File Offset: 0x0001817C
		public unsafe string CurrentIngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x0010B56C File Offset: 0x0010976C
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x00019F9B File Offset: 0x0001819B
		public unsafe int CurrentIngredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity)) = value;
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x0010B594 File Offset: 0x00109794
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x00019FB6 File Offset: 0x000181B6
		public unsafe EQuality CurrentIngredientQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality)) = value;
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x0010B5BC File Offset: 0x001097BC
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x00019FD1 File Offset: 0x000181D1
		public unsafe string CurrentProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x0010B5E4 File Offset: 0x001097E4
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00019FF0 File Offset: 0x000181F0
		public unsafe int CurrentCookProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress)) = value;
			}
		}

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientID;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientQuantity;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientQuality;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeFieldInfoPtr_CurrentProductID;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCookProgress;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0;
	}
}
