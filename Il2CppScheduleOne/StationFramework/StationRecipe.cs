using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000592 RID: 1426
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x06007D81 RID: 32129 RVA: 0x00219F2C File Offset: 0x0021812C
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipe()
		{
			Il2CppClassPointerStore<StationRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr);
			StationRecipe.NativeFieldInfoPtr_IsDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IsDiscovered");
			StationRecipe.NativeFieldInfoPtr_RecipeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "RecipeTitle");
			StationRecipe.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Unlocked");
			StationRecipe.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Ingredients");
			StationRecipe.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Product");
			StationRecipe.NativeFieldInfoPtr_FinalLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "FinalLiquidColor");
			StationRecipe.NativeFieldInfoPtr_CookTime_Mins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTime_Mins");
			StationRecipe.NativeFieldInfoPtr_CookTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperature");
			StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperatureTolerance");
			StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "QualityCalculationMethod");
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100678997);
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100678998);
			StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100678999);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679000);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679001);
			StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679002);
			StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679003);
			StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679004);
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06007D82 RID: 32130 RVA: 0x0021A0C4 File Offset: 0x002182C4
		public unsafe float CookTemperatureLowerBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06007D83 RID: 32131 RVA: 0x0021A100 File Offset: 0x00218300
		public unsafe float CookTemperatureUpperBound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06007D84 RID: 32132 RVA: 0x0021A13C File Offset: 0x0021833C
		public unsafe string RecipeID
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 237945, RefRangeEnd = 237950, XrefRangeStart = 237940, XrefRangeEnd = 237945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06007D85 RID: 32133 RVA: 0x0021A174 File Offset: 0x00218374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237958, RefRangeEnd = 237961, XrefRangeStart = 237950, XrefRangeEnd = 237958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x0021A1C4 File Offset: 0x002183C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237963, RefRangeEnd = 237964, XrefRangeStart = 237961, XrefRangeEnd = 237963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x0021A210 File Offset: 0x00218410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238016, RefRangeEnd = 238017, XrefRangeStart = 237964, XrefRangeEnd = 238016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x0021A260 File Offset: 0x00218460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238030, RefRangeEnd = 238033, XrefRangeStart = 238017, XrefRangeEnd = 238030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x0021A2B0 File Offset: 0x002184B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238033, XrefRangeEnd = 238041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x0003BA63 File Offset: 0x00039C63
		public StationRecipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06007D8B RID: 32139 RVA: 0x0021A2EC File Offset: 0x002184EC
		// (set) Token: 0x06007D8C RID: 32140 RVA: 0x0003BA6C File Offset: 0x00039C6C
		public unsafe bool IsDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered)) = value;
			}
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06007D8D RID: 32141 RVA: 0x0021A314 File Offset: 0x00218514
		// (set) Token: 0x06007D8E RID: 32142 RVA: 0x0003BA87 File Offset: 0x00039C87
		public unsafe string RecipeTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06007D8F RID: 32143 RVA: 0x0021A33C File Offset: 0x0021853C
		// (set) Token: 0x06007D90 RID: 32144 RVA: 0x0003BAA6 File Offset: 0x00039CA6
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x0021A364 File Offset: 0x00218564
		// (set) Token: 0x06007D92 RID: 32146 RVA: 0x0003BAC1 File Offset: 0x00039CC1
		public unsafe List<StationRecipe.IngredientQuantity> Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe.IngredientQuantity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0021A394 File Offset: 0x00218594
		// (set) Token: 0x06007D94 RID: 32148 RVA: 0x0003BAE0 File Offset: 0x00039CE0
		public unsafe StationRecipe.ItemQuantity Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe.ItemQuantity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0021A3C4 File Offset: 0x002185C4
		// (set) Token: 0x06007D96 RID: 32150 RVA: 0x0003BAFF File Offset: 0x00039CFF
		public unsafe Color FinalLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor)) = value;
			}
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06007D97 RID: 32151 RVA: 0x0021A3EC File Offset: 0x002185EC
		// (set) Token: 0x06007D98 RID: 32152 RVA: 0x0003BB1A File Offset: 0x00039D1A
		public unsafe int CookTime_Mins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins)) = value;
			}
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06007D99 RID: 32153 RVA: 0x0021A414 File Offset: 0x00218614
		// (set) Token: 0x06007D9A RID: 32154 RVA: 0x0003BB35 File Offset: 0x00039D35
		public unsafe float CookTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature)) = value;
			}
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0021A43C File Offset: 0x0021863C
		// (set) Token: 0x06007D9C RID: 32156 RVA: 0x0003BB50 File Offset: 0x00039D50
		public unsafe float CookTemperatureTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance)) = value;
			}
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0021A464 File Offset: 0x00218664
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0003BB6B File Offset: 0x00039D6B
		public unsafe StationRecipe.EQualityCalculationMethod QualityCalculationMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod)) = value;
			}
		}

		// Token: 0x04005560 RID: 21856
		private static readonly IntPtr NativeFieldInfoPtr_IsDiscovered;

		// Token: 0x04005561 RID: 21857
		private static readonly IntPtr NativeFieldInfoPtr_RecipeTitle;

		// Token: 0x04005562 RID: 21858
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04005563 RID: 21859
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04005564 RID: 21860
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x04005565 RID: 21861
		private static readonly IntPtr NativeFieldInfoPtr_FinalLiquidColor;

		// Token: 0x04005566 RID: 21862
		private static readonly IntPtr NativeFieldInfoPtr_CookTime_Mins;

		// Token: 0x04005567 RID: 21863
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperature;

		// Token: 0x04005568 RID: 21864
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperatureTolerance;

		// Token: 0x04005569 RID: 21865
		private static readonly IntPtr NativeFieldInfoPtr_QualityCalculationMethod;

		// Token: 0x0400556A RID: 21866
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0;

		// Token: 0x0400556B RID: 21867
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0;

		// Token: 0x0400556C RID: 21868
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeID_Public_get_String_0;

		// Token: 0x0400556D RID: 21869
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0;

		// Token: 0x0400556E RID: 21870
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0;

		// Token: 0x0400556F RID: 21871
		private static readonly IntPtr NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0;

		// Token: 0x04005570 RID: 21872
		private static readonly IntPtr NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0;

		// Token: 0x04005571 RID: 21873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC0 RID: 2752
		[OriginalName("Assembly-CSharp.dll", "", "EQualityCalculationMethod")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x04008EBD RID: 36541
			Additive
		}

		// Token: 0x02000AC1 RID: 2753
		[Serializable]
		public class ItemQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D3F2 RID: 54258 RVA: 0x00329AA4 File Offset: 0x00327CA4
			// Note: this type is marked as 'beforefieldinit'.
			static ItemQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "ItemQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr);
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Item");
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, 100679005);
			}

			// Token: 0x0600D3F3 RID: 54259 RVA: 0x00329B0C File Offset: 0x00327D0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237912, XrefRangeEnd = 237913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3F4 RID: 54260 RVA: 0x00067293 File Offset: 0x00065493
			public ItemQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B6 RID: 16822
			// (get) Token: 0x0600D3F5 RID: 54261 RVA: 0x00329B48 File Offset: 0x00327D48
			// (set) Token: 0x0600D3F6 RID: 54262 RVA: 0x0006729C File Offset: 0x0006549C
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B7 RID: 16823
			// (get) Token: 0x0600D3F7 RID: 54263 RVA: 0x00329B78 File Offset: 0x00327D78
			// (set) Token: 0x0600D3F8 RID: 54264 RVA: 0x000672BB File Offset: 0x000654BB
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008EBE RID: 36542
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008EBF RID: 36543
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008EC0 RID: 36544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC2 RID: 2754
		[Serializable]
		public class IngredientQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600D3F9 RID: 54265 RVA: 0x00329BA0 File Offset: 0x00327DA0
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IngredientQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr);
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Items");
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679006);
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679007);
			}

			// Token: 0x170041BA RID: 16826
			// (get) Token: 0x0600D3FA RID: 54266 RVA: 0x00329C1C File Offset: 0x00327E1C
			public unsafe ItemDefinition Item
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 237916, RefRangeEnd = 237928, XrefRangeStart = 237913, XrefRangeEnd = 237916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3FB RID: 54267 RVA: 0x00329C5C File Offset: 0x00327E5C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 237936, RefRangeEnd = 237938, XrefRangeStart = 237928, XrefRangeEnd = 237936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3FC RID: 54268 RVA: 0x000672D6 File Offset: 0x000654D6
			public IngredientQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041B8 RID: 16824
			// (get) Token: 0x0600D3FD RID: 54269 RVA: 0x00329C98 File Offset: 0x00327E98
			// (set) Token: 0x0600D3FE RID: 54270 RVA: 0x000672DF File Offset: 0x000654DF
			public unsafe List<ItemDefinition> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041B9 RID: 16825
			// (get) Token: 0x0600D3FF RID: 54271 RVA: 0x00329CC8 File Offset: 0x00327EC8
			// (set) Token: 0x0600D400 RID: 54272 RVA: 0x000672FE File Offset: 0x000654FE
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008EC1 RID: 36545
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04008EC2 RID: 36546
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008EC3 RID: 36547
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0;

			// Token: 0x04008EC4 RID: 36548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC3 RID: 2755
		[ObfuscatedName("ScheduleOne.StationFramework.StationRecipe+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D401 RID: 54273 RVA: 0x00329CF0 File Offset: 0x00327EF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr);
				StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, "ingredientVariant");
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679008);
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679009);
			}

			// Token: 0x0600D402 RID: 54274 RVA: 0x00329D58 File Offset: 0x00327F58
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D403 RID: 54275 RVA: 0x00329D94 File Offset: 0x00327F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237938, XrefRangeEnd = 237940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoIngredientsSuffice_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D404 RID: 54276 RVA: 0x00067319 File Offset: 0x00065519
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BB RID: 16827
			// (get) Token: 0x0600D405 RID: 54277 RVA: 0x00329DE4 File Offset: 0x00327FE4
			// (set) Token: 0x0600D406 RID: 54278 RVA: 0x00067322 File Offset: 0x00065522
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EC5 RID: 36549
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04008EC6 RID: 36550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC7 RID: 36551
			private static readonly IntPtr NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0;
		}
	}
}
