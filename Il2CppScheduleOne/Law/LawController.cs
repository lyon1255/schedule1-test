using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D7 RID: 983
	public class LawController : Singleton<LawController>
	{
		// Token: 0x06004BDC RID: 19420 RVA: 0x0016DD7C File Offset: 0x0016BF7C
		// Note: this type is marked as 'beforefieldinit'.
		static LawController()
		{
			Il2CppClassPointerStore<LawController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawController>.NativeClassPtr);
			LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "DAILY_INTENSITY_DRAIN");
			LawController.NativeFieldInfoPtr_LE_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "LE_Intensity");
			LawController.NativeFieldInfoPtr_internalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "internalLawIntensity");
			LawController.NativeFieldInfoPtr_MondaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "MondaySettings");
			LawController.NativeFieldInfoPtr_TuesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "TuesdaySettings");
			LawController.NativeFieldInfoPtr_WednesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "WednesdaySettings");
			LawController.NativeFieldInfoPtr_ThursdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "ThursdaySettings");
			LawController.NativeFieldInfoPtr_FridaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "FridaySettings");
			LawController.NativeFieldInfoPtr_SaturdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SaturdaySettings");
			LawController.NativeFieldInfoPtr_SundaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SundaySettings");
			LawController.NativeFieldInfoPtr_IntensityIncreasePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "IntensityIncreasePerDay");
			LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverrideSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverriddenSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			LawController.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "loader");
			LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LawController.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<HasChanged>k__BackingField");
			LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672685);
			LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672686);
			LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672687);
			LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672688);
			LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672689);
			LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672690);
			LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672691);
			LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672692);
			LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672693);
			LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672694);
			LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672695);
			LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672696);
			LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672697);
			LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672698);
			LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672699);
			LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672700);
			LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672701);
			LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672702);
			LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672703);
			LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672704);
			LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672705);
			LawController.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672706);
			LawController.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672707);
			LawController.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672708);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672709);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672710);
			LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672711);
			LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672712);
			LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672713);
			LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672714);
			LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672715);
			LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672716);
			LawController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672717);
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x0016E1A8 File Offset: 0x0016C3A8
		// (set) Token: 0x06004BDE RID: 19422 RVA: 0x0016E1E4 File Offset: 0x0016C3E4
		public unsafe bool OverrideSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x0016E224 File Offset: 0x0016C424
		// (set) Token: 0x06004BE0 RID: 19424 RVA: 0x0016E264 File Offset: 0x0016C464
		public unsafe LawActivitySettings OverriddenSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22967, RefRangeEnd = 22968, XrefRangeStart = 22967, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x0016E2A8 File Offset: 0x0016C4A8
		// (set) Token: 0x06004BE2 RID: 19426 RVA: 0x0016E2E8 File Offset: 0x0016C4E8
		public unsafe LawActivitySettings CurrentSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45797, RefRangeEnd = 45798, XrefRangeStart = 45797, XrefRangeEnd = 45798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165065, XrefRangeEnd = 165066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x0016E32C File Offset: 0x0016C52C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165066, XrefRangeEnd = 165068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06004BE4 RID: 19428 RVA: 0x0016E364 File Offset: 0x0016C564
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165068, XrefRangeEnd = 165070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x0016E39C File Offset: 0x0016C59C
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0016E3DC File Offset: 0x0016C5DC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x0016E418 File Offset: 0x0016C618
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x0016E458 File Offset: 0x0016C658
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95744, RefRangeEnd = 95745, XrefRangeStart = 95744, XrefRangeEnd = 95745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x0016E49C File Offset: 0x0016C69C
		// (set) Token: 0x06004BEA RID: 19434 RVA: 0x0016E4DC File Offset: 0x0016C6DC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 31092, RefRangeEnd = 31099, XrefRangeStart = 31092, XrefRangeEnd = 31099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165070, XrefRangeEnd = 165071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x0016E520 File Offset: 0x0016C720
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x0016E55C File Offset: 0x0016C75C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x0016E59C File Offset: 0x0016C79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165071, XrefRangeEnd = 165074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x0016E5D8 File Offset: 0x0016C7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165074, XrefRangeEnd = 165080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x0016E614 File Offset: 0x0016C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165080, XrefRangeEnd = 165142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x0016E650 File Offset: 0x0016C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165142, XrefRangeEnd = 165196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x0016E68C File Offset: 0x0016C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165196, XrefRangeEnd = 165205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x0016E6C0 File Offset: 0x0016C8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165205, XrefRangeEnd = 165210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x0016E6F4 File Offset: 0x0016C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x0016E728 File Offset: 0x0016C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165210, XrefRangeEnd = 165214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x0016E75C File Offset: 0x0016C95C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165215, RefRangeEnd = 165217, XrefRangeStart = 165214, XrefRangeEnd = 165215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x0016E79C File Offset: 0x0016C99C
		[CallerCount(0)]
		public unsafe LawActivitySettings GetSettings(EDay day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr3) : null;
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x0016E7E8 File Offset: 0x0016C9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165217, XrefRangeEnd = 165218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSetings(LawActivitySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x0016E82C File Offset: 0x0016CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165218, XrefRangeEnd = 165219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x0016E860 File Offset: 0x0016CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165219, XrefRangeEnd = 165222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternalIntensity(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x0016E8A0 File Offset: 0x0016CAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165225, RefRangeEnd = 165226, XrefRangeStart = 165222, XrefRangeEnd = 165225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternalIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x0016E8E0 File Offset: 0x0016CAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165226, XrefRangeEnd = 165231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x0016E924 File Offset: 0x0016CB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165234, RefRangeEnd = 165235, XrefRangeStart = 165231, XrefRangeEnd = 165234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(LawData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x0016E968 File Offset: 0x0016CB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165235, XrefRangeEnd = 165255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x000247A2 File Offset: 0x000229A2
		public LawController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06004BFF RID: 19455 RVA: 0x0016E9A4 File Offset: 0x0016CBA4
		// (set) Token: 0x06004C00 RID: 19456 RVA: 0x000247AB File Offset: 0x000229AB
		public unsafe static float DAILY_INTENSITY_DRAIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&value));
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0016E9C0 File Offset: 0x0016CBC0
		// (set) Token: 0x06004C02 RID: 19458 RVA: 0x000247B9 File Offset: 0x000229B9
		public unsafe int LE_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity)) = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x0016E9E8 File Offset: 0x0016CBE8
		// (set) Token: 0x06004C04 RID: 19460 RVA: 0x000247D4 File Offset: 0x000229D4
		public unsafe float internalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity)) = value;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x0016EA10 File Offset: 0x0016CC10
		// (set) Token: 0x06004C06 RID: 19462 RVA: 0x000247EF File Offset: 0x000229EF
		public unsafe LawActivitySettings MondaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x0016EA40 File Offset: 0x0016CC40
		// (set) Token: 0x06004C08 RID: 19464 RVA: 0x0002480E File Offset: 0x00022A0E
		public unsafe LawActivitySettings TuesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x0016EA70 File Offset: 0x0016CC70
		// (set) Token: 0x06004C0A RID: 19466 RVA: 0x0002482D File Offset: 0x00022A2D
		public unsafe LawActivitySettings WednesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x0016EAA0 File Offset: 0x0016CCA0
		// (set) Token: 0x06004C0C RID: 19468 RVA: 0x0002484C File Offset: 0x00022A4C
		public unsafe LawActivitySettings ThursdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x0016EAD0 File Offset: 0x0016CCD0
		// (set) Token: 0x06004C0E RID: 19470 RVA: 0x0002486B File Offset: 0x00022A6B
		public unsafe LawActivitySettings FridaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x0016EB00 File Offset: 0x0016CD00
		// (set) Token: 0x06004C10 RID: 19472 RVA: 0x0002488A File Offset: 0x00022A8A
		public unsafe LawActivitySettings SaturdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0016EB30 File Offset: 0x0016CD30
		// (set) Token: 0x06004C12 RID: 19474 RVA: 0x000248A9 File Offset: 0x00022AA9
		public unsafe LawActivitySettings SundaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0016EB60 File Offset: 0x0016CD60
		// (set) Token: 0x06004C14 RID: 19476 RVA: 0x000248C8 File Offset: 0x00022AC8
		public unsafe float IntensityIncreasePerDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay)) = value;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06004C15 RID: 19477 RVA: 0x0016EB88 File Offset: 0x0016CD88
		// (set) Token: 0x06004C16 RID: 19478 RVA: 0x000248E3 File Offset: 0x00022AE3
		public unsafe bool _OverrideSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0016EBB0 File Offset: 0x0016CDB0
		// (set) Token: 0x06004C18 RID: 19480 RVA: 0x000248FE File Offset: 0x00022AFE
		public unsafe LawActivitySettings _OverriddenSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0016EBE0 File Offset: 0x0016CDE0
		// (set) Token: 0x06004C1A RID: 19482 RVA: 0x0002491D File Offset: 0x00022B1D
		public unsafe LawActivitySettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06004C1B RID: 19483 RVA: 0x0016EC10 File Offset: 0x0016CE10
		// (set) Token: 0x06004C1C RID: 19484 RVA: 0x0002493C File Offset: 0x00022B3C
		public unsafe LawLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06004C1D RID: 19485 RVA: 0x0016EC40 File Offset: 0x0016CE40
		// (set) Token: 0x06004C1E RID: 19486 RVA: 0x0002495B File Offset: 0x00022B5B
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004C1F RID: 19487 RVA: 0x0016EC70 File Offset: 0x0016CE70
		// (set) Token: 0x06004C20 RID: 19488 RVA: 0x0002497A File Offset: 0x00022B7A
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x06004C21 RID: 19489 RVA: 0x0016ECA0 File Offset: 0x0016CEA0
		// (set) Token: 0x06004C22 RID: 19490 RVA: 0x00024999 File Offset: 0x00022B99
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeFieldInfoPtr_LE_Intensity;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeFieldInfoPtr_internalLawIntensity;

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeFieldInfoPtr_MondaySettings;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeFieldInfoPtr_TuesdaySettings;

		// Token: 0x04003326 RID: 13094
		private static readonly IntPtr NativeFieldInfoPtr_WednesdaySettings;

		// Token: 0x04003327 RID: 13095
		private static readonly IntPtr NativeFieldInfoPtr_ThursdaySettings;

		// Token: 0x04003328 RID: 13096
		private static readonly IntPtr NativeFieldInfoPtr_FridaySettings;

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeFieldInfoPtr_SaturdaySettings;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeFieldInfoPtr_SundaySettings;

		// Token: 0x0400332B RID: 13099
		private static readonly IntPtr NativeFieldInfoPtr_IntensityIncreasePerDay;

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeFieldInfoPtr__OverrideSettings_k__BackingField;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenSettings_k__BackingField;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_LawData_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
