using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073F RID: 1855
	public class ChemistryCookOperation : Il2CppSystem.Object
	{
		// Token: 0x0600AB4A RID: 43850 RVA: 0x002AC050 File Offset: 0x002AA250
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryCookOperation()
		{
			Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "ChemistryCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr);
			ChemistryCookOperation.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "recipe");
			ChemistryCookOperation.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "RecipeID");
			ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "ProductQuality");
			ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "StartLiquidColor");
			ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "LiquidLevel");
			ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "CurrentTime");
			ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684306);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684307);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684308);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684309);
			ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684310);
			ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100684311);
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600AB4B RID: 43851 RVA: 0x002AC170 File Offset: 0x002AA370
		public unsafe StationRecipe Recipe
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 296932, RefRangeEnd = 296943, XrefRangeStart = 296914, XrefRangeEnd = 296932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x002AC1B0 File Offset: 0x002AA3B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296946, RefRangeEnd = 296948, XrefRangeStart = 296943, XrefRangeEnd = 296946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x002AC234 File Offset: 0x002AA434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296950, RefRangeEnd = 296951, XrefRangeStart = 296948, XrefRangeEnd = 296950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x002AC2B8 File Offset: 0x002AA4B8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x002AC2F4 File Offset: 0x002AA4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296951, XrefRangeEnd = 296952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Progress(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x002AC334 File Offset: 0x002AA534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296952, XrefRangeEnd = 296955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Recipe_b__2_0(StationRecipe r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x00054510 File Offset: 0x00052710
		public ChemistryCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600AB52 RID: 43858 RVA: 0x002AC384 File Offset: 0x002AA584
		// (set) Token: 0x0600AB53 RID: 43859 RVA: 0x00054519 File Offset: 0x00052719
		public unsafe StationRecipe recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600AB54 RID: 43860 RVA: 0x002AC3B4 File Offset: 0x002AA5B4
		// (set) Token: 0x0600AB55 RID: 43861 RVA: 0x00054538 File Offset: 0x00052738
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600AB56 RID: 43862 RVA: 0x002AC3DC File Offset: 0x002AA5DC
		// (set) Token: 0x0600AB57 RID: 43863 RVA: 0x00054557 File Offset: 0x00052757
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600AB58 RID: 43864 RVA: 0x002AC404 File Offset: 0x002AA604
		// (set) Token: 0x0600AB59 RID: 43865 RVA: 0x00054572 File Offset: 0x00052772
		public unsafe Color StartLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600AB5A RID: 43866 RVA: 0x002AC42C File Offset: 0x002AA62C
		// (set) Token: 0x0600AB5B RID: 43867 RVA: 0x0005458D File Offset: 0x0005278D
		public unsafe float LiquidLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600AB5C RID: 43868 RVA: 0x002AC454 File Offset: 0x002AA654
		// (set) Token: 0x0600AB5D RID: 43869 RVA: 0x000545A8 File Offset: 0x000527A8
		public unsafe int CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x04007313 RID: 29459
		private static readonly IntPtr NativeFieldInfoPtr_recipe;

		// Token: 0x04007314 RID: 29460
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04007315 RID: 29461
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04007316 RID: 29462
		private static readonly IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x04007317 RID: 29463
		private static readonly IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x04007318 RID: 29464
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x04007319 RID: 29465
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x0400731A RID: 29466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0;

		// Token: 0x0400731B RID: 29467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0;

		// Token: 0x0400731C RID: 29468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400731D RID: 29469
		private static readonly IntPtr NativeMethodInfoPtr_Progress_Public_Void_Int32_0;

		// Token: 0x0400731E RID: 29470
		private static readonly IntPtr NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0;
	}
}
