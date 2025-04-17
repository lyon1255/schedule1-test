using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000559 RID: 1369
	public class Plant : MonoBehaviour
	{
		// Token: 0x0600785E RID: 30814 RVA: 0x0020891C File Offset: 0x00206B1C
		// Note: this type is marked as 'beforefieldinit'.
		static Plant()
		{
			Il2CppClassPointerStore<Plant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Plant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plant>.NativeClassPtr);
			Plant.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<Pot>k__BackingField");
			Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<NormalizedGrowthProgress>k__BackingField");
			Plant.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "VisualsContainer");
			Plant.NativeFieldInfoPtr_GrowthStages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthStages");
			Plant.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "Collider");
			Plant.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SnipSound");
			Plant.NativeFieldInfoPtr_DestroySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "DestroySound");
			Plant.NativeFieldInfoPtr_FullyGrownParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "FullyGrownParticles");
			Plant.NativeFieldInfoPtr_SeedDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SeedDefinition");
			Plant.NativeFieldInfoPtr_GrowthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthTime");
			Plant.NativeFieldInfoPtr_BaseYieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseYieldLevel");
			Plant.NativeFieldInfoPtr_BaseQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseQualityLevel");
			Plant.NativeFieldInfoPtr_HarvestTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "HarvestTarget");
			Plant.NativeFieldInfoPtr_PlantScrapPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "PlantScrapPrefab");
			Plant.NativeFieldInfoPtr_onGrowthDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "onGrowthDone");
			Plant.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "YieldLevel");
			Plant.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "QualityLevel");
			Plant.NativeFieldInfoPtr_ActiveHarvestables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "ActiveHarvestables");
			Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678408);
			Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678409);
			Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678410);
			Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678411);
			Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678412);
			Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678413);
			Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678414);
			Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678415);
			Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678416);
			Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678417);
			Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678418);
			Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678419);
			Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678420);
			Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678421);
			Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678422);
			Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678423);
			Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678424);
			Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678425);
			Plant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678426);
		}

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600785F RID: 30815 RVA: 0x00208C30 File Offset: 0x00206E30
		// (set) Token: 0x06007860 RID: 30816 RVA: 0x00208C70 File Offset: 0x00206E70
		public unsafe Pot Pot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x00208CB4 File Offset: 0x00206EB4
		// (set) Token: 0x06007862 RID: 30818 RVA: 0x00208CF0 File Offset: 0x00206EF0
		public unsafe float NormalizedGrowthProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x00208D30 File Offset: 0x00206F30
		public unsafe bool IsFullyGrown
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 232261, RefRangeEnd = 232266, XrefRangeStart = 232261, XrefRangeEnd = 232261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x00208D6C File Offset: 0x00206F6C
		public unsafe PlantGrowthStage FinalGrowthStage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 232266, RefRangeEnd = 232267, XrefRangeStart = 232266, XrefRangeEnd = 232266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantGrowthStage>(intPtr3) : null;
			}
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00208DAC File Offset: 0x00206FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232267, XrefRangeEnd = 232278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00208E24 File Offset: 0x00207024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232278, XrefRangeEnd = 232309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy(bool dropScraps = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dropScraps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00208E70 File Offset: 0x00207070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232309, XrefRangeEnd = 232319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00208EAC File Offset: 0x002070AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232319, XrefRangeEnd = 232321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedGrowthProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00208EF8 File Offset: 0x002070F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232321, XrefRangeEnd = 232328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00208F34 File Offset: 0x00207134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232328, XrefRangeEnd = 232336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHarvestableActive(int index, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00208F8C File Offset: 0x0020718C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232340, RefRangeEnd = 232341, XrefRangeStart = 232336, XrefRangeEnd = 232340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHarvestableActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00208FD8 File Offset: 0x002071D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232369, RefRangeEnd = 232370, XrefRangeStart = 232341, XrefRangeEnd = 232369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowthDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x0020900C File Offset: 0x0020720C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232397, RefRangeEnd = 232398, XrefRangeStart = 232370, XrefRangeEnd = 232397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00209074 File Offset: 0x00207274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232401, RefRangeEnd = 232403, XrefRangeStart = 232398, XrefRangeEnd = 232401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x002090B4 File Offset: 0x002072B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232403, XrefRangeEnd = 232409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x0020910C File Offset: 0x0020730C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232416, RefRangeEnd = 232417, XrefRangeStart = 232409, XrefRangeEnd = 232416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData GetPlantData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr3) : null;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x0020914C File Offset: 0x0020734C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232429, RefRangeEnd = 232431, XrefRangeStart = 232417, XrefRangeEnd = 232429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x00039173 File Offset: 0x00037373
		public Plant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x06007873 RID: 30835 RVA: 0x00209188 File Offset: 0x00207388
		// (set) Token: 0x06007874 RID: 30836 RVA: 0x0003917C File Offset: 0x0003737C
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x06007875 RID: 30837 RVA: 0x002091B8 File Offset: 0x002073B8
		// (set) Token: 0x06007876 RID: 30838 RVA: 0x0003919B File Offset: 0x0003739B
		public unsafe float _NormalizedGrowthProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x002091E0 File Offset: 0x002073E0
		// (set) Token: 0x06007878 RID: 30840 RVA: 0x000391B6 File Offset: 0x000373B6
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x06007879 RID: 30841 RVA: 0x00209210 File Offset: 0x00207410
		// (set) Token: 0x0600787A RID: 30842 RVA: 0x000391D5 File Offset: 0x000373D5
		public unsafe Il2CppReferenceArray<PlantGrowthStage> GrowthStages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlantGrowthStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600787B RID: 30843 RVA: 0x00209240 File Offset: 0x00207440
		// (set) Token: 0x0600787C RID: 30844 RVA: 0x000391F4 File Offset: 0x000373F4
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600787D RID: 30845 RVA: 0x00209270 File Offset: 0x00207470
		// (set) Token: 0x0600787E RID: 30846 RVA: 0x00039213 File Offset: 0x00037413
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x002092A0 File Offset: 0x002074A0
		// (set) Token: 0x06007880 RID: 30848 RVA: 0x00039232 File Offset: 0x00037432
		public unsafe AudioSourceController DestroySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06007881 RID: 30849 RVA: 0x002092D0 File Offset: 0x002074D0
		// (set) Token: 0x06007882 RID: 30850 RVA: 0x00039251 File Offset: 0x00037451
		public unsafe ParticleSystem FullyGrownParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x06007883 RID: 30851 RVA: 0x00209300 File Offset: 0x00207500
		// (set) Token: 0x06007884 RID: 30852 RVA: 0x00039270 File Offset: 0x00037470
		public unsafe SeedDefinition SeedDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x06007885 RID: 30853 RVA: 0x00209330 File Offset: 0x00207530
		// (set) Token: 0x06007886 RID: 30854 RVA: 0x0003928F File Offset: 0x0003748F
		public unsafe int GrowthTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime)) = value;
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x00209358 File Offset: 0x00207558
		// (set) Token: 0x06007888 RID: 30856 RVA: 0x000392AA File Offset: 0x000374AA
		public unsafe float BaseYieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldLevel)) = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x06007889 RID: 30857 RVA: 0x00209380 File Offset: 0x00207580
		// (set) Token: 0x0600788A RID: 30858 RVA: 0x000392C5 File Offset: 0x000374C5
		public unsafe float BaseQualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseQualityLevel)) = value;
			}
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x002093A8 File Offset: 0x002075A8
		// (set) Token: 0x0600788C RID: 30860 RVA: 0x000392E0 File Offset: 0x000374E0
		public unsafe string HarvestTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x002093D0 File Offset: 0x002075D0
		// (set) Token: 0x0600788E RID: 30862 RVA: 0x000392FF File Offset: 0x000374FF
		public unsafe TrashItem PlantScrapPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600788F RID: 30863 RVA: 0x00209400 File Offset: 0x00207600
		// (set) Token: 0x06007890 RID: 30864 RVA: 0x0003931E File Offset: 0x0003751E
		public unsafe UnityEvent onGrowthDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onGrowthDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06007891 RID: 30865 RVA: 0x00209430 File Offset: 0x00207630
		// (set) Token: 0x06007892 RID: 30866 RVA: 0x0003933D File Offset: 0x0003753D
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x00209458 File Offset: 0x00207658
		// (set) Token: 0x06007894 RID: 30868 RVA: 0x00039358 File Offset: 0x00037558
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x06007895 RID: 30869 RVA: 0x00209480 File Offset: 0x00207680
		// (set) Token: 0x06007896 RID: 30870 RVA: 0x00039373 File Offset: 0x00037573
		public unsafe List<int> ActiveHarvestables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005204 RID: 20996
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x04005205 RID: 20997
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField;

		// Token: 0x04005206 RID: 20998
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04005207 RID: 20999
		private static readonly IntPtr NativeFieldInfoPtr_GrowthStages;

		// Token: 0x04005208 RID: 21000
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005209 RID: 21001
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x0400520A RID: 21002
		private static readonly IntPtr NativeFieldInfoPtr_DestroySound;

		// Token: 0x0400520B RID: 21003
		private static readonly IntPtr NativeFieldInfoPtr_FullyGrownParticles;

		// Token: 0x0400520C RID: 21004
		private static readonly IntPtr NativeFieldInfoPtr_SeedDefinition;

		// Token: 0x0400520D RID: 21005
		private static readonly IntPtr NativeFieldInfoPtr_GrowthTime;

		// Token: 0x0400520E RID: 21006
		private static readonly IntPtr NativeFieldInfoPtr_BaseYieldLevel;

		// Token: 0x0400520F RID: 21007
		private static readonly IntPtr NativeFieldInfoPtr_BaseQualityLevel;

		// Token: 0x04005210 RID: 21008
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTarget;

		// Token: 0x04005211 RID: 21009
		private static readonly IntPtr NativeFieldInfoPtr_PlantScrapPrefab;

		// Token: 0x04005212 RID: 21010
		private static readonly IntPtr NativeFieldInfoPtr_onGrowthDone;

		// Token: 0x04005213 RID: 21011
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x04005214 RID: 21012
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04005215 RID: 21013
		private static readonly IntPtr NativeFieldInfoPtr_ActiveHarvestables;

		// Token: 0x04005216 RID: 21014
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x04005217 RID: 21015
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x04005218 RID: 21016
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0;

		// Token: 0x04005219 RID: 21017
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0;

		// Token: 0x0400521A RID: 21018
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0;

		// Token: 0x0400521B RID: 21019
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0;

		// Token: 0x0400521C RID: 21020
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_Single_Single_0;

		// Token: 0x0400521D RID: 21021
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400521E RID: 21022
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x0400521F RID: 21023
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0;

		// Token: 0x04005220 RID: 21024
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04005221 RID: 21025
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x04005222 RID: 21026
		private static readonly IntPtr NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0;

		// Token: 0x04005223 RID: 21027
		private static readonly IntPtr NativeMethodInfoPtr_GrowthDone_Private_Void_0;

		// Token: 0x04005224 RID: 21028
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0;

		// Token: 0x04005225 RID: 21029
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04005226 RID: 21030
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005227 RID: 21031
		private static readonly IntPtr NativeMethodInfoPtr_GetPlantData_Public_PlantData_0;

		// Token: 0x04005228 RID: 21032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
