using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000680 RID: 1664
	public class MixingStationCanvas : Singleton<MixingStationCanvas>
	{
		// Token: 0x060094EE RID: 38126 RVA: 0x00263848 File Offset: 0x00261A48
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationCanvas()
		{
			Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "MixingStationCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr);
			MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "<MixingStation>k__BackingField");
			MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "RecipeEntryPrefab");
			MixingStationCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Canvas");
			MixingStationCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "Container");
			MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "IngredientProblemLabel");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewLabel");
			MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "UnknownOutputIcon");
			MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "PreviewPropertiesLabel");
			MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "OutputSlotUI");
			MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "InstructionLabel");
			MixingStationCanvas.NativeFieldInfoPtr_TitleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "TitleContainer");
			MixingStationCanvas.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MainContainer");
			MixingStationCanvas.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "BeginButton");
			MixingStationCanvas.NativeFieldInfoPtr_ProductHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "ProductHint");
			MixingStationCanvas.NativeFieldInfoPtr_MixerHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "MixerHint");
			MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, "selectedRecipe");
			MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681724);
			MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681725);
			MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681726);
			MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681727);
			MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681728);
			MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681729);
			MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681730);
			MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681731);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681732);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681733);
			MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681734);
			MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681735);
			MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681736);
			MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681737);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681738);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681739);
			MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681740);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681741);
			MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681742);
			MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681743);
			MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681744);
			MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681745);
			MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681746);
			MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681747);
			MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681748);
			MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr, 100681749);
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x00263C38 File Offset: 0x00261E38
		// (set) Token: 0x060094F0 RID: 38128 RVA: 0x00263C74 File Offset: 0x00261E74
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x060094F1 RID: 38129 RVA: 0x00263CB4 File Offset: 0x00261EB4
		// (set) Token: 0x060094F2 RID: 38130 RVA: 0x00263CF4 File Offset: 0x00261EF4
		public unsafe MixingStation MixingStation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00263D38 File Offset: 0x00261F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267548, XrefRangeEnd = 267559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00263D74 File Offset: 0x00261F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267559, XrefRangeEnd = 267576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x00263DB0 File Offset: 0x00261FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267576, XrefRangeEnd = 267584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x00263DF4 File Offset: 0x00261FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267584, XrefRangeEnd = 267589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationCanvas.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x00263E30 File Offset: 0x00262030
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00263E64 File Offset: 0x00262064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267589, XrefRangeEnd = 267591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x00263E98 File Offset: 0x00262098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267779, RefRangeEnd = 267780, XrefRangeStart = 267591, XrefRangeEnd = 267779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x00263EDC File Offset: 0x002620DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267840, RefRangeEnd = 267843, XrefRangeStart = 267780, XrefRangeEnd = 267840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool enablePlayerControl = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enablePlayerControl;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x00263F1C File Offset: 0x0026211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267843, XrefRangeEnd = 267901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixingDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x00263F50 File Offset: 0x00262150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267901, XrefRangeEnd = 267910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x00263F84 File Offset: 0x00262184
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 267925, RefRangeEnd = 267930, XrefRangeStart = 267910, XrefRangeEnd = 267925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x00263FB8 File Offset: 0x002621B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267941, RefRangeEnd = 267944, XrefRangeStart = 267930, XrefRangeEnd = 267941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x00263FEC File Offset: 0x002621EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268033, RefRangeEnd = 268036, XrefRangeStart = 267944, XrefRangeEnd = 268033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreview()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdatePreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x00264020 File Offset: 0x00262220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268048, RefRangeEnd = 268050, XrefRangeStart = 268036, XrefRangeEnd = 268048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x00264068 File Offset: 0x00262268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268068, RefRangeEnd = 268070, XrefRangeStart = 268050, XrefRangeEnd = 268068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x002640B0 File Offset: 0x002622B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268070, XrefRangeEnd = 268076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00264114 File Offset: 0x00262314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268076, XrefRangeEnd = 268103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00264174 File Offset: 0x00262374
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 268111, RefRangeEnd = 268114, XrefRangeStart = 268103, XrefRangeEnd = 268111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeginButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x002641A8 File Offset: 0x002623A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268160, RefRangeEnd = 268161, XrefRangeStart = 268114, XrefRangeEnd = 268160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x002641DC File Offset: 0x002623DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268177, RefRangeEnd = 268178, XrefRangeStart = 268161, XrefRangeEnd = 268177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixOperation(MixOperation mixOperation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mixOperation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x00264220 File Offset: 0x00262420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268178, XrefRangeEnd = 268202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixNamed(string mixName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mixName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr_MixNamed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009508 RID: 38152 RVA: 0x00264264 File Offset: 0x00262464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268202, XrefRangeEnd = 268205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x000485C6 File Offset: 0x000467C6
		public MixingStationCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600950A RID: 38154 RVA: 0x002642A0 File Offset: 0x002624A0
		// (set) Token: 0x0600950B RID: 38155 RVA: 0x000485CF File Offset: 0x000467CF
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600950C RID: 38156 RVA: 0x002642C8 File Offset: 0x002624C8
		// (set) Token: 0x0600950D RID: 38157 RVA: 0x000485EA File Offset: 0x000467EA
		public unsafe MixingStation _MixingStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr__MixingStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600950E RID: 38158 RVA: 0x002642F8 File Offset: 0x002624F8
		// (set) Token: 0x0600950F RID: 38159 RVA: 0x00048609 File Offset: 0x00046809
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x06009510 RID: 38160 RVA: 0x00264328 File Offset: 0x00262528
		// (set) Token: 0x06009511 RID: 38161 RVA: 0x00048628 File Offset: 0x00046828
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x06009512 RID: 38162 RVA: 0x00264358 File Offset: 0x00262558
		// (set) Token: 0x06009513 RID: 38163 RVA: 0x00048647 File Offset: 0x00046847
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x06009514 RID: 38164 RVA: 0x00264388 File Offset: 0x00262588
		// (set) Token: 0x06009515 RID: 38165 RVA: 0x00048666 File Offset: 0x00046866
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x06009516 RID: 38166 RVA: 0x002643B8 File Offset: 0x002625B8
		// (set) Token: 0x06009517 RID: 38167 RVA: 0x00048685 File Offset: 0x00046885
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x06009518 RID: 38168 RVA: 0x002643E8 File Offset: 0x002625E8
		// (set) Token: 0x06009519 RID: 38169 RVA: 0x000486A4 File Offset: 0x000468A4
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x00264418 File Offset: 0x00262618
		// (set) Token: 0x0600951B RID: 38171 RVA: 0x000486C3 File Offset: 0x000468C3
		public unsafe TextMeshProUGUI IngredientProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_IngredientProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x0600951C RID: 38172 RVA: 0x00264448 File Offset: 0x00262648
		// (set) Token: 0x0600951D RID: 38173 RVA: 0x000486E2 File Offset: 0x000468E2
		public unsafe ItemSlotUI PreviewSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x0600951E RID: 38174 RVA: 0x00264478 File Offset: 0x00262678
		// (set) Token: 0x0600951F RID: 38175 RVA: 0x00048701 File Offset: 0x00046901
		public unsafe Image PreviewIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x06009520 RID: 38176 RVA: 0x002644A8 File Offset: 0x002626A8
		// (set) Token: 0x06009521 RID: 38177 RVA: 0x00048720 File Offset: 0x00046920
		public unsafe TextMeshProUGUI PreviewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x06009522 RID: 38178 RVA: 0x002644D8 File Offset: 0x002626D8
		// (set) Token: 0x06009523 RID: 38179 RVA: 0x0004873F File Offset: 0x0004693F
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x06009524 RID: 38180 RVA: 0x00264508 File Offset: 0x00262708
		// (set) Token: 0x06009525 RID: 38181 RVA: 0x0004875E File Offset: 0x0004695E
		public unsafe TextMeshProUGUI PreviewPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_PreviewPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x06009526 RID: 38182 RVA: 0x00264538 File Offset: 0x00262738
		// (set) Token: 0x06009527 RID: 38183 RVA: 0x0004877D File Offset: 0x0004697D
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06009528 RID: 38184 RVA: 0x00264568 File Offset: 0x00262768
		// (set) Token: 0x06009529 RID: 38185 RVA: 0x0004879C File Offset: 0x0004699C
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x0600952A RID: 38186 RVA: 0x00264598 File Offset: 0x00262798
		// (set) Token: 0x0600952B RID: 38187 RVA: 0x000487BB File Offset: 0x000469BB
		public unsafe RectTransform TitleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_TitleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600952C RID: 38188 RVA: 0x002645C8 File Offset: 0x002627C8
		// (set) Token: 0x0600952D RID: 38189 RVA: 0x000487DA File Offset: 0x000469DA
		public unsafe RectTransform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600952E RID: 38190 RVA: 0x002645F8 File Offset: 0x002627F8
		// (set) Token: 0x0600952F RID: 38191 RVA: 0x000487F9 File Offset: 0x000469F9
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x06009530 RID: 38192 RVA: 0x00264628 File Offset: 0x00262828
		// (set) Token: 0x06009531 RID: 38193 RVA: 0x00048818 File Offset: 0x00046A18
		public unsafe RectTransform ProductHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_ProductHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x00264658 File Offset: 0x00262858
		// (set) Token: 0x06009533 RID: 38195 RVA: 0x00048837 File Offset: 0x00046A37
		public unsafe RectTransform MixerHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_MixerHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00264688 File Offset: 0x00262888
		// (set) Token: 0x06009535 RID: 38197 RVA: 0x00048856 File Offset: 0x00046A56
		public unsafe StationRecipe selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationCanvas.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006472 RID: 25714
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006473 RID: 25715
		private static readonly IntPtr NativeFieldInfoPtr__MixingStation_k__BackingField;

		// Token: 0x04006474 RID: 25716
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04006475 RID: 25717
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006476 RID: 25718
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006477 RID: 25719
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x04006478 RID: 25720
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04006479 RID: 25721
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x0400647A RID: 25722
		private static readonly IntPtr NativeFieldInfoPtr_IngredientProblemLabel;

		// Token: 0x0400647B RID: 25723
		private static readonly IntPtr NativeFieldInfoPtr_PreviewSlotUI;

		// Token: 0x0400647C RID: 25724
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIcon;

		// Token: 0x0400647D RID: 25725
		private static readonly IntPtr NativeFieldInfoPtr_PreviewLabel;

		// Token: 0x0400647E RID: 25726
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x0400647F RID: 25727
		private static readonly IntPtr NativeFieldInfoPtr_PreviewPropertiesLabel;

		// Token: 0x04006480 RID: 25728
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04006481 RID: 25729
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04006482 RID: 25730
		private static readonly IntPtr NativeFieldInfoPtr_TitleContainer;

		// Token: 0x04006483 RID: 25731
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04006484 RID: 25732
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04006485 RID: 25733
		private static readonly IntPtr NativeFieldInfoPtr_ProductHint;

		// Token: 0x04006486 RID: 25734
		private static readonly IntPtr NativeFieldInfoPtr_MixerHint;

		// Token: 0x04006487 RID: 25735
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04006488 RID: 25736
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006489 RID: 25737
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400648A RID: 25738
		private static readonly IntPtr NativeMethodInfoPtr_get_MixingStation_Public_get_MixingStation_0;

		// Token: 0x0400648B RID: 25739
		private static readonly IntPtr NativeMethodInfoPtr_set_MixingStation_Protected_set_Void_MixingStation_0;

		// Token: 0x0400648C RID: 25740
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400648D RID: 25741
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400648E RID: 25742
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400648F RID: 25743
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006490 RID: 25744
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04006491 RID: 25745
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04006492 RID: 25746
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_MixingStation_0;

		// Token: 0x04006493 RID: 25747
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006494 RID: 25748
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Private_Void_0;

		// Token: 0x04006495 RID: 25749
		private static readonly IntPtr NativeMethodInfoPtr_StationContentsChanged_Private_Void_0;

		// Token: 0x04006496 RID: 25750
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0;

		// Token: 0x04006497 RID: 25751
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04006498 RID: 25752
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreview_Private_Void_0;

		// Token: 0x04006499 RID: 25753
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x0400649A RID: 25754
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x0400649B RID: 25755
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x0400649C RID: 25756
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x0400649D RID: 25757
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0;

		// Token: 0x0400649E RID: 25758
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x0400649F RID: 25759
		private static readonly IntPtr NativeMethodInfoPtr_StartMixOperation_Public_Void_MixOperation_0;

		// Token: 0x040064A0 RID: 25760
		private static readonly IntPtr NativeMethodInfoPtr_MixNamed_Private_Void_String_0;

		// Token: 0x040064A1 RID: 25761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
