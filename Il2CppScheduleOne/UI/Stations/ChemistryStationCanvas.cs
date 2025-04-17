using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200067C RID: 1660
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		// Token: 0x0600943E RID: 37950 RVA: 0x00261764 File Offset: 0x0025F964
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationCanvas()
		{
			Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "ChemistryStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr);
			ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<ChemistryStation>k__BackingField");
			ChemistryStationCanvas.NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Recipes");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			ChemistryStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Canvas");
			ChemistryStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "Container");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotsContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InputSlotUIs");
			ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "OutputSlotUI");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeSelectionContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InstructionLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "BeginButton");
			ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "SelectionIndicator");
			ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "RecipeContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "CookingInProgressContainer");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressRecipeEntry");
			ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "InProgressLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "ErrorLabel");
			ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "recipeEntries");
			ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "selectedRecipe");
			ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681658);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681659);
			ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681660);
			ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681661);
			ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681662);
			ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681663);
			ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681664);
			ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681665);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681666);
			ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681667);
			ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681668);
			ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681669);
			ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681670);
			ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681671);
			ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681672);
			ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681673);
			ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, 100681674);
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600943F RID: 37951 RVA: 0x00261A78 File Offset: 0x0025FC78
		// (set) Token: 0x06009440 RID: 37952 RVA: 0x00261AB4 File Offset: 0x0025FCB4
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x06009441 RID: 37953 RVA: 0x00261AF4 File Offset: 0x0025FCF4
		// (set) Token: 0x06009442 RID: 37954 RVA: 0x00261B34 File Offset: 0x0025FD34
		public unsafe ChemistryStation ChemistryStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x00261B78 File Offset: 0x0025FD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266474, XrefRangeEnd = 266504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x00261BB4 File Offset: 0x0025FDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266504, XrefRangeEnd = 266508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x00261BF0 File Offset: 0x0025FDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266508, XrefRangeEnd = 266537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x00261C2C File Offset: 0x0025FE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266537, XrefRangeEnd = 266544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x00261C60 File Offset: 0x0025FE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266559, RefRangeEnd = 266561, XrefRangeStart = 266544, XrefRangeEnd = 266559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x00261C94 File Offset: 0x0025FE94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266595, RefRangeEnd = 266596, XrefRangeStart = 266561, XrefRangeEnd = 266595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00261CC8 File Offset: 0x0025FEC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266692, RefRangeEnd = 266694, XrefRangeStart = 266596, XrefRangeEnd = 266692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00261D0C File Offset: 0x0025FF0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 266737, RefRangeEnd = 266741, XrefRangeStart = 266694, XrefRangeEnd = 266737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool removeUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref removeUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x00261D4C File Offset: 0x0025FF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266741, XrefRangeEnd = 266752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x00261D80 File Offset: 0x0025FF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266752, XrefRangeEnd = 266771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationSlotsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x00261DB4 File Offset: 0x0025FFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266812, RefRangeEnd = 266814, XrefRangeStart = 266771, XrefRangeEnd = 266812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortRecipes(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00261DF8 File Offset: 0x0025FFF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 266827, RefRangeEnd = 266829, XrefRangeStart = 266814, XrefRangeEnd = 266827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRecipe(StationRecipeEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00261E3C File Offset: 0x0026003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266829, XrefRangeEnd = 266846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00047EED File Offset: 0x000460ED
		public ChemistryStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x06009451 RID: 37969 RVA: 0x00261E78 File Offset: 0x00260078
		// (set) Token: 0x06009452 RID: 37970 RVA: 0x00047EF6 File Offset: 0x000460F6
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06009453 RID: 37971 RVA: 0x00261EA0 File Offset: 0x002600A0
		// (set) Token: 0x06009454 RID: 37972 RVA: 0x00047F11 File Offset: 0x00046111
		public unsafe ChemistryStation _ChemistryStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr__ChemistryStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06009455 RID: 37973 RVA: 0x00261ED0 File Offset: 0x002600D0
		// (set) Token: 0x06009456 RID: 37974 RVA: 0x00047F30 File Offset: 0x00046130
		public unsafe List<StationRecipe> Recipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x00261F00 File Offset: 0x00260100
		// (set) Token: 0x06009458 RID: 37976 RVA: 0x00047F4F File Offset: 0x0004614F
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06009459 RID: 37977 RVA: 0x00261F30 File Offset: 0x00260130
		// (set) Token: 0x0600945A RID: 37978 RVA: 0x00047F6E File Offset: 0x0004616E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x0600945B RID: 37979 RVA: 0x00261F60 File Offset: 0x00260160
		// (set) Token: 0x0600945C RID: 37980 RVA: 0x00047F8D File Offset: 0x0004618D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x0600945D RID: 37981 RVA: 0x00261F90 File Offset: 0x00260190
		// (set) Token: 0x0600945E RID: 37982 RVA: 0x00047FAC File Offset: 0x000461AC
		public unsafe RectTransform InputSlotsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x0600945F RID: 37983 RVA: 0x00261FC0 File Offset: 0x002601C0
		// (set) Token: 0x06009460 RID: 37984 RVA: 0x00047FCB File Offset: 0x000461CB
		public unsafe Il2CppReferenceArray<ItemSlotUI> InputSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InputSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x06009461 RID: 37985 RVA: 0x00261FF0 File Offset: 0x002601F0
		// (set) Token: 0x06009462 RID: 37986 RVA: 0x00047FEA File Offset: 0x000461EA
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x06009463 RID: 37987 RVA: 0x00262020 File Offset: 0x00260220
		// (set) Token: 0x06009464 RID: 37988 RVA: 0x00048009 File Offset: 0x00046209
		public unsafe RectTransform RecipeSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x06009465 RID: 37989 RVA: 0x00262050 File Offset: 0x00260250
		// (set) Token: 0x06009466 RID: 37990 RVA: 0x00048028 File Offset: 0x00046228
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06009467 RID: 37991 RVA: 0x00262080 File Offset: 0x00260280
		// (set) Token: 0x06009468 RID: 37992 RVA: 0x00048047 File Offset: 0x00046247
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06009469 RID: 37993 RVA: 0x002620B0 File Offset: 0x002602B0
		// (set) Token: 0x0600946A RID: 37994 RVA: 0x00048066 File Offset: 0x00046266
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600946B RID: 37995 RVA: 0x002620E0 File Offset: 0x002602E0
		// (set) Token: 0x0600946C RID: 37996 RVA: 0x00048085 File Offset: 0x00046285
		public unsafe RectTransform RecipeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_RecipeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600946D RID: 37997 RVA: 0x00262110 File Offset: 0x00260310
		// (set) Token: 0x0600946E RID: 37998 RVA: 0x000480A4 File Offset: 0x000462A4
		public unsafe RectTransform CookingInProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_CookingInProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x00262140 File Offset: 0x00260340
		// (set) Token: 0x06009470 RID: 38000 RVA: 0x000480C3 File Offset: 0x000462C3
		public unsafe StationRecipeEntry InProgressRecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressRecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x06009471 RID: 38001 RVA: 0x00262170 File Offset: 0x00260370
		// (set) Token: 0x06009472 RID: 38002 RVA: 0x000480E2 File Offset: 0x000462E2
		public unsafe TextMeshProUGUI InProgressLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_InProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x002621A0 File Offset: 0x002603A0
		// (set) Token: 0x06009474 RID: 38004 RVA: 0x00048101 File Offset: 0x00046301
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x06009475 RID: 38005 RVA: 0x002621D0 File Offset: 0x002603D0
		// (set) Token: 0x06009476 RID: 38006 RVA: 0x00048120 File Offset: 0x00046320
		public unsafe List<StationRecipeEntry> recipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_recipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x00262200 File Offset: 0x00260400
		// (set) Token: 0x06009478 RID: 38008 RVA: 0x0004813F File Offset: 0x0004633F
		public unsafe StationRecipeEntry selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006403 RID: 25603
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006404 RID: 25604
		private static readonly IntPtr NativeFieldInfoPtr__ChemistryStation_k__BackingField;

		// Token: 0x04006405 RID: 25605
		private static readonly IntPtr NativeFieldInfoPtr_Recipes;

		// Token: 0x04006406 RID: 25606
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04006407 RID: 25607
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006408 RID: 25608
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006409 RID: 25609
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotsContainer;

		// Token: 0x0400640A RID: 25610
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUIs;

		// Token: 0x0400640B RID: 25611
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400640C RID: 25612
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectionContainer;

		// Token: 0x0400640D RID: 25613
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400640E RID: 25614
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x0400640F RID: 25615
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006410 RID: 25616
		private static readonly IntPtr NativeFieldInfoPtr_RecipeContainer;

		// Token: 0x04006411 RID: 25617
		private static readonly IntPtr NativeFieldInfoPtr_CookingInProgressContainer;

		// Token: 0x04006412 RID: 25618
		private static readonly IntPtr NativeFieldInfoPtr_InProgressRecipeEntry;

		// Token: 0x04006413 RID: 25619
		private static readonly IntPtr NativeFieldInfoPtr_InProgressLabel;

		// Token: 0x04006414 RID: 25620
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04006415 RID: 25621
		private static readonly IntPtr NativeFieldInfoPtr_recipeEntries;

		// Token: 0x04006416 RID: 25622
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04006417 RID: 25623
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006418 RID: 25624
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006419 RID: 25625
		private static readonly IntPtr NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0;

		// Token: 0x0400641A RID: 25626
		private static readonly IntPtr NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x0400641B RID: 25627
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400641C RID: 25628
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400641D RID: 25629
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400641E RID: 25630
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400641F RID: 25631
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006420 RID: 25632
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04006421 RID: 25633
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0;

		// Token: 0x04006422 RID: 25634
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006423 RID: 25635
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04006424 RID: 25636
		private static readonly IntPtr NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0;

		// Token: 0x04006425 RID: 25637
		private static readonly IntPtr NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04006426 RID: 25638
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0;

		// Token: 0x04006427 RID: 25639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B59 RID: 2905
		[ObfuscatedName("ScheduleOne.UI.Stations.ChemistryStationCanvas+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA17 RID: 55831 RVA: 0x0033B514 File Offset: 0x00339714
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistryStationCanvas>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, "recipes");
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100681675);
				ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr, 100681676);
			}

			// Token: 0x0600DA18 RID: 55832 RVA: 0x0033B57C File Offset: 0x0033977C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationCanvas.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA19 RID: 55833 RVA: 0x0033B5B8 File Offset: 0x003397B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266468, XrefRangeEnd = 266474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortRecipes_b__0(StationRecipeEntry a, StationRecipeEntry b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationCanvas.__c__DisplayClass36_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DA1A RID: 55834 RVA: 0x0006A357 File Offset: 0x00068557
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AB RID: 17323
			// (get) Token: 0x0600DA1B RID: 55835 RVA: 0x0033B618 File Offset: 0x00339818
			// (set) Token: 0x0600DA1C RID: 55836 RVA: 0x0006A360 File Offset: 0x00068560
			public unsafe Dictionary<StationRecipeEntry, float> recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StationRecipeEntry, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationCanvas.__c__DisplayClass36_0.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009270 RID: 37488
			private static readonly IntPtr NativeFieldInfoPtr_recipes;

			// Token: 0x04009271 RID: 37489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009272 RID: 37490
			private static readonly IntPtr NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0;
		}
	}
}
