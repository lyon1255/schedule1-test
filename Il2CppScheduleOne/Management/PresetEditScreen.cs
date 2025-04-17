using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options.SetterScreens;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A1 RID: 929
	public class PresetEditScreen : MonoBehaviour
	{
		// Token: 0x060048BB RID: 18619 RVA: 0x0016387C File Offset: 0x00161A7C
		// Note: this type is marked as 'beforefieldinit'.
		static PresetEditScreen()
		{
			Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr);
			PresetEditScreen.NativeFieldInfoPtr_EditedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditedPreset");
			PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackgroundRect");
			PresetEditScreen.NativeFieldInfoPtr_IconBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackground");
			PresetEditScreen.NativeFieldInfoPtr_InputFieldRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputFieldRect");
			PresetEditScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputField");
			PresetEditScreen.NativeFieldInfoPtr_EditButtonRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditButtonRect");
			PresetEditScreen.NativeFieldInfoPtr_ReturnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "ReturnButton");
			PresetEditScreen.NativeFieldInfoPtr_DeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "DeleteButton");
			PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672313);
			PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672314);
			PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672315);
			PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672316);
			PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672317);
			PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672318);
			PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672319);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672320);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672321);
			PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672322);
			PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672323);
			PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672324);
			PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672325);
			PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672326);
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x00163A64 File Offset: 0x00161C64
		public unsafe bool isOpen
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 162582, RefRangeEnd = 162590, XrefRangeStart = 162582, XrefRangeEnd = 162582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00163AA0 File Offset: 0x00161CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162630, RefRangeEnd = 162631, XrefRangeStart = 162590, XrefRangeEnd = 162630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00163ADC File Offset: 0x00161CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162631, XrefRangeEnd = 162634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00163B20 File Offset: 0x00161D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162647, RefRangeEnd = 162648, XrefRangeStart = 162634, XrefRangeEnd = 162647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00163B70 File Offset: 0x00161D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162648, XrefRangeEnd = 162652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00163BA4 File Offset: 0x00161DA4
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00163BD8 File Offset: 0x00161DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162670, RefRangeEnd = 162673, XrefRangeStart = 162652, XrefRangeEnd = 162670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00163C0C File Offset: 0x00161E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162673, XrefRangeEnd = 162674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldChange(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00163C50 File Offset: 0x00161E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162674, XrefRangeEnd = 162685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldDone(string piss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(piss);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00163C94 File Offset: 0x00161E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162685, XrefRangeEnd = 162692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameAppropriate(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00163CE4 File Offset: 0x00161EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162692, XrefRangeEnd = 162698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00163D18 File Offset: 0x00161F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00163D4C File Offset: 0x00161F4C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00163D88 File Offset: 0x00161F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162698, XrefRangeEnd = 162703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x000230C8 File Offset: 0x000212C8
		public PresetEditScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x00163DC8 File Offset: 0x00161FC8
		// (set) Token: 0x060048CC RID: 18636 RVA: 0x000230D1 File Offset: 0x000212D1
		public unsafe Preset EditedPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00163DF8 File Offset: 0x00161FF8
		// (set) Token: 0x060048CE RID: 18638 RVA: 0x000230F0 File Offset: 0x000212F0
		public unsafe RectTransform IconBackgroundRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x00163E28 File Offset: 0x00162028
		// (set) Token: 0x060048D0 RID: 18640 RVA: 0x0002310F File Offset: 0x0002130F
		public unsafe Image IconBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x060048D1 RID: 18641 RVA: 0x00163E58 File Offset: 0x00162058
		// (set) Token: 0x060048D2 RID: 18642 RVA: 0x0002312E File Offset: 0x0002132E
		public unsafe RectTransform InputFieldRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x060048D3 RID: 18643 RVA: 0x00163E88 File Offset: 0x00162088
		// (set) Token: 0x060048D4 RID: 18644 RVA: 0x0002314D File Offset: 0x0002134D
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x00163EB8 File Offset: 0x001620B8
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x0002316C File Offset: 0x0002136C
		public unsafe RectTransform EditButtonRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00163EE8 File Offset: 0x001620E8
		// (set) Token: 0x060048D8 RID: 18648 RVA: 0x0002318B File Offset: 0x0002138B
		public unsafe Button ReturnButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x00163F18 File Offset: 0x00162118
		// (set) Token: 0x060048DA RID: 18650 RVA: 0x000231AA File Offset: 0x000213AA
		public unsafe Button DeleteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeFieldInfoPtr_EditedPreset;

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeFieldInfoPtr_IconBackgroundRect;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeFieldInfoPtr_IconBackground;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeFieldInfoPtr_InputFieldRect;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeFieldInfoPtr_EditButtonRect;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeFieldInfoPtr_ReturnButton;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeFieldInfoPtr_DeleteButton;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransforms_Private_Void_0;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000979 RID: 2425
		[Serializable]
		public class OptionData : Il2CppSystem.Object
		{
			// Token: 0x0600C9C1 RID: 51649 RVA: 0x0030D2F0 File Offset: 0x0030B4F0
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr);
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionEntryPrefab");
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionSetterScreen");
				PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, 100672327);
			}

			// Token: 0x0600C9C2 RID: 51650 RVA: 0x0030D358 File Offset: 0x0030B558
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9C3 RID: 51651 RVA: 0x000621A6 File Offset: 0x000603A6
			public OptionData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE5 RID: 16101
			// (get) Token: 0x0600C9C4 RID: 51652 RVA: 0x0030D394 File Offset: 0x0030B594
			// (set) Token: 0x0600C9C5 RID: 51653 RVA: 0x000621AF File Offset: 0x000603AF
			public unsafe GameObject OptionEntryPrefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE6 RID: 16102
			// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x0030D3C4 File Offset: 0x0030B5C4
			// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x000621CE File Offset: 0x000603CE
			public unsafe OptionSetterScreen OptionSetterScreen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSetterScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008887 RID: 34951
			private static readonly IntPtr NativeFieldInfoPtr_OptionEntryPrefab;

			// Token: 0x04008888 RID: 34952
			private static readonly IntPtr NativeFieldInfoPtr_OptionSetterScreen;

			// Token: 0x04008889 RID: 34953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200097A RID: 2426
		[ObfuscatedName("ScheduleOne.Management.PresetEditScreen+<<Open>g__Delay|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C9C8 RID: 51656 RVA: 0x0030D3F4 File Offset: 0x0030B5F4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "<<Open>g__Delay|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672328);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672329);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672330);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672331);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672332);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672333);
			}

			// Token: 0x0600C9C9 RID: 51657 RVA: 0x0030D4D4 File Offset: 0x0030B6D4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9CA RID: 51658 RVA: 0x0030D51C File Offset: 0x0030B71C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9CB RID: 51659 RVA: 0x0030D550 File Offset: 0x0030B750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162572, XrefRangeEnd = 162577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EEA RID: 16106
			// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x0030D58C File Offset: 0x0030B78C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C9CD RID: 51661 RVA: 0x0030D5CC File Offset: 0x0030B7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162577, XrefRangeEnd = 162582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EEB RID: 16107
			// (get) Token: 0x0600C9CE RID: 51662 RVA: 0x0030D600 File Offset: 0x0030B800
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C9CF RID: 51663 RVA: 0x000621ED File Offset: 0x000603ED
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE7 RID: 16103
			// (get) Token: 0x0600C9D0 RID: 51664 RVA: 0x0030D640 File Offset: 0x0030B840
			// (set) Token: 0x0600C9D1 RID: 51665 RVA: 0x000621F6 File Offset: 0x000603F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EE8 RID: 16104
			// (get) Token: 0x0600C9D2 RID: 51666 RVA: 0x0030D668 File Offset: 0x0030B868
			// (set) Token: 0x0600C9D3 RID: 51667 RVA: 0x00062211 File Offset: 0x00060411
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE9 RID: 16105
			// (get) Token: 0x0600C9D4 RID: 51668 RVA: 0x0030D698 File Offset: 0x0030B898
			// (set) Token: 0x0600C9D5 RID: 51669 RVA: 0x00062230 File Offset: 0x00060430
			public unsafe PresetEditScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PresetEditScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400888A RID: 34954
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400888B RID: 34955
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400888C RID: 34956
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400888D RID: 34957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400888E RID: 34958
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400888F RID: 34959
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008890 RID: 34960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008891 RID: 34961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008892 RID: 34962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
