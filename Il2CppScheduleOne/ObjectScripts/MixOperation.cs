using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200074E RID: 1870
	[Serializable]
	public class MixOperation : Object
	{
		// Token: 0x0600B065 RID: 45157 RVA: 0x002BFE54 File Offset: 0x002BE054
		// Note: this type is marked as 'beforefieldinit'.
		static MixOperation()
		{
			Il2CppClassPointerStore<MixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixOperation>.NativeClassPtr);
			MixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductID");
			MixOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductQuality");
			MixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "IngredientID");
			MixOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "Quantity");
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100684994);
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100684995);
			MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100684996);
			MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100684997);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002BFF24 File Offset: 0x002BE124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304009, RefRangeEnd = 304011, XrefRangeStart = 304006, XrefRangeEnd = 304009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x002BFFA0 File Offset: 0x002BE1A0
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x002BFFDC File Offset: 0x002BE1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304025, RefRangeEnd = 304027, XrefRangeStart = 304011, XrefRangeEnd = 304025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDrugType GetOutput(out List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			properties = ((intPtr4 == 0) ? null : new List<Property>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x002C003C File Offset: 0x002BE23C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 304050, RefRangeEnd = 304055, XrefRangeStart = 304027, XrefRangeEnd = 304050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x00056A33 File Offset: 0x00054C33
		public MixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600B06B RID: 45163 RVA: 0x002C009C File Offset: 0x002BE29C
		// (set) Token: 0x0600B06C RID: 45164 RVA: 0x00056A3C File Offset: 0x00054C3C
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600B06D RID: 45165 RVA: 0x002C00C4 File Offset: 0x002BE2C4
		// (set) Token: 0x0600B06E RID: 45166 RVA: 0x00056A5B File Offset: 0x00054C5B
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600B06F RID: 45167 RVA: 0x002C00EC File Offset: 0x002BE2EC
		// (set) Token: 0x0600B070 RID: 45168 RVA: 0x00056A76 File Offset: 0x00054C76
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600B071 RID: 45169 RVA: 0x002C0114 File Offset: 0x002BE314
		// (set) Token: 0x0600B072 RID: 45170 RVA: 0x00056A95 File Offset: 0x00054C95
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040076D1 RID: 30417
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040076D2 RID: 30418
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x040076D3 RID: 30419
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040076D4 RID: 30420
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040076D5 RID: 30421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0;

		// Token: 0x040076D6 RID: 30422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040076D7 RID: 30423
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0;

		// Token: 0x040076D8 RID: 30424
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0;
	}
}
