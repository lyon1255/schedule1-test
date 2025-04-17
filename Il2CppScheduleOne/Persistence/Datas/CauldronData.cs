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
	// Token: 0x02000295 RID: 661
	public class CauldronData : GridItemData
	{
		// Token: 0x06003083 RID: 12419 RVA: 0x0010A8E8 File Offset: 0x00108AE8
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronData()
		{
			Il2CppClassPointerStore<CauldronData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronData>.NativeClassPtr);
			CauldronData.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Ingredients");
			CauldronData.NativeFieldInfoPtr_Liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Liquid");
			CauldronData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Output");
			CauldronData.NativeFieldInfoPtr_RemainingCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "RemainingCookTime");
			CauldronData.NativeFieldInfoPtr_InputQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "InputQuality");
			CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, 100668810);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0010A990 File Offset: 0x00108B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130881, RefRangeEnd = 130882, XrefRangeStart = 130872, XrefRangeEnd = 130881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(liquid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingCookTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x00019CDB File Offset: 0x00017EDB
		public CauldronData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x0010AA80 File Offset: 0x00108C80
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x00019CE4 File Offset: 0x00017EE4
		public unsafe ItemSet Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x0010AAB0 File Offset: 0x00108CB0
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x00019D03 File Offset: 0x00017F03
		public unsafe ItemSet Liquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x0010AAE0 File Offset: 0x00108CE0
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x00019D22 File Offset: 0x00017F22
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x0010AB10 File Offset: 0x00108D10
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x00019D41 File Offset: 0x00017F41
		public unsafe int RemainingCookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime)) = value;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x0010AB38 File Offset: 0x00108D38
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x00019D5C File Offset: 0x00017F5C
		public unsafe EQuality InputQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality)) = value;
			}
		}

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_Liquid;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_RemainingCookTime;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_InputQuality;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0;
	}
}
