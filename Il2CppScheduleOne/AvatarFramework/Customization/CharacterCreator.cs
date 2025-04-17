using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.CharacterCreator;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000617 RID: 1559
	public class CharacterCreator : Singleton<CharacterCreator>
	{
		// Token: 0x060089CA RID: 35274 RVA: 0x00242678 File Offset: 0x00240878
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreator()
		{
			Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CharacterCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr);
			CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Fields");
			CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<ActiveSettings>k__BackingField");
			CharacterCreator.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Container");
			CharacterCreator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CameraPosition");
			CharacterCreator.NativeFieldInfoPtr_RigContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "RigContainer");
			CharacterCreator.NativeFieldInfoPtr_Rig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Rig");
			CharacterCreator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Canvas");
			CharacterCreator.NativeFieldInfoPtr_CanvasAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "CanvasAnimation");
			CharacterCreator.NativeFieldInfoPtr_DemoCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DemoCreator");
			CharacterCreator.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "DefaultSettings");
			CharacterCreator.NativeFieldInfoPtr_Presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "Presets");
			CharacterCreator.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onComplete");
			CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "onCompleteWithClothing");
			CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "lastSelectedClothingDefinitions");
			CharacterCreator.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "rigTargetY");
			CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680420);
			CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680421);
			CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680422);
			CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680423);
			CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680424);
			CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680425);
			CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680426);
			CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680427);
			CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680428);
			CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680429);
			CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680430);
			CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680431);
			CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680432);
			CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680433);
			CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680434);
			CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680435);
			CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680436);
			CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, 100680437);
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x00242950 File Offset: 0x00240B50
		// (set) Token: 0x060089CC RID: 35276 RVA: 0x0024298C File Offset: 0x00240B8C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x002429CC File Offset: 0x00240BCC
		// (set) Token: 0x060089CE RID: 35278 RVA: 0x00242A0C File Offset: 0x00240C0C
		public unsafe BasicAvatarSettings ActiveSettings
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060089CF RID: 35279 RVA: 0x00242A50 File Offset: 0x00240C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253502, XrefRangeEnd = 253515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D0 RID: 35280 RVA: 0x00242A8C File Offset: 0x00240C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253515, XrefRangeEnd = 253521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D1 RID: 35281 RVA: 0x00242AC8 File Offset: 0x00240CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253521, XrefRangeEnd = 253525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D2 RID: 35282 RVA: 0x00242AFC File Offset: 0x00240CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253585, RefRangeEnd = 253587, XrefRangeStart = 253525, XrefRangeEnd = 253585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BasicAvatarSettings initialSettings, bool showUI = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(initialSettings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x00242B4C File Offset: 0x00240D4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253602, RefRangeEnd = 253605, XrefRangeStart = 253587, XrefRangeEnd = 253602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_ShowUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x00242B80 File Offset: 0x00240D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253605, XrefRangeEnd = 253611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x00242BB4 File Offset: 0x00240DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253614, RefRangeEnd = 253615, XrefRangeStart = 253611, XrefRangeEnd = 253614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_DisableStuff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x00242BE8 File Offset: 0x00240DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253615, XrefRangeEnd = 253669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Done()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Done_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x00242C1C File Offset: 0x00240E1C
		[CallerCount(0)]
		public unsafe void SliderChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00242C5C File Offset: 0x00240E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253689, RefRangeEnd = 253690, XrefRangeStart = 253669, XrefRangeEnd = 253689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SetValue<T>(string fieldName, T value, ClothingDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x00242D18 File Offset: 0x00240F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253690, XrefRangeEnd = 253728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_SelectPreset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00242D5C File Offset: 0x00240F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253732, RefRangeEnd = 253733, XrefRangeStart = 253728, XrefRangeEnd = 253732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCategory(CharacterCreator.ECategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x00242D9C File Offset: 0x00240F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253733, XrefRangeEnd = 253750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x00242DD8 File Offset: 0x00240FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253750, XrefRangeEnd = 253755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060089DD RID: 35293 RVA: 0x00041E01 File Offset: 0x00040001
		public CharacterCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x060089DE RID: 35294 RVA: 0x00242E18 File Offset: 0x00241018
		// (set) Token: 0x060089DF RID: 35295 RVA: 0x00041E0A File Offset: 0x0004000A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x060089E0 RID: 35296 RVA: 0x00242E40 File Offset: 0x00241040
		// (set) Token: 0x060089E1 RID: 35297 RVA: 0x00041E25 File Offset: 0x00040025
		public unsafe List<BaseCharacterCreatorField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseCharacterCreatorField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x060089E2 RID: 35298 RVA: 0x00242E70 File Offset: 0x00241070
		// (set) Token: 0x060089E3 RID: 35299 RVA: 0x00041E44 File Offset: 0x00040044
		public unsafe BasicAvatarSettings _ActiveSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr__ActiveSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x060089E4 RID: 35300 RVA: 0x00242EA0 File Offset: 0x002410A0
		// (set) Token: 0x060089E5 RID: 35301 RVA: 0x00041E63 File Offset: 0x00040063
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x060089E6 RID: 35302 RVA: 0x00242ED0 File Offset: 0x002410D0
		// (set) Token: 0x060089E7 RID: 35303 RVA: 0x00041E82 File Offset: 0x00040082
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x060089E8 RID: 35304 RVA: 0x00242F00 File Offset: 0x00241100
		// (set) Token: 0x060089E9 RID: 35305 RVA: 0x00041EA1 File Offset: 0x000400A1
		public unsafe Transform RigContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_RigContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x060089EA RID: 35306 RVA: 0x00242F30 File Offset: 0x00241130
		// (set) Token: 0x060089EB RID: 35307 RVA: 0x00041EC0 File Offset: 0x000400C0
		public unsafe Avatar Rig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Rig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x060089EC RID: 35308 RVA: 0x00242F60 File Offset: 0x00241160
		// (set) Token: 0x060089ED RID: 35309 RVA: 0x00041EDF File Offset: 0x000400DF
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x060089EE RID: 35310 RVA: 0x00242F90 File Offset: 0x00241190
		// (set) Token: 0x060089EF RID: 35311 RVA: 0x00041EFE File Offset: 0x000400FE
		public unsafe Animation CanvasAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_CanvasAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x060089F0 RID: 35312 RVA: 0x00242FC0 File Offset: 0x002411C0
		// (set) Token: 0x060089F1 RID: 35313 RVA: 0x00041F1D File Offset: 0x0004011D
		public unsafe bool DemoCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DemoCreator)) = value;
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x060089F2 RID: 35314 RVA: 0x00242FE8 File Offset: 0x002411E8
		// (set) Token: 0x060089F3 RID: 35315 RVA: 0x00041F38 File Offset: 0x00040138
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x060089F4 RID: 35316 RVA: 0x00243018 File Offset: 0x00241218
		// (set) Token: 0x060089F5 RID: 35317 RVA: 0x00041F57 File Offset: 0x00040157
		public unsafe List<BasicAvatarSettings> Presets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_Presets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x00243048 File Offset: 0x00241248
		// (set) Token: 0x060089F7 RID: 35319 RVA: 0x00041F76 File Offset: 0x00040176
		public unsafe UnityEvent<BasicAvatarSettings> onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x00243078 File Offset: 0x00241278
		// (set) Token: 0x060089F9 RID: 35321 RVA: 0x00041F95 File Offset: 0x00040195
		public unsafe UnityEvent<BasicAvatarSettings, List<ClothingInstance>> onCompleteWithClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BasicAvatarSettings, List<ClothingInstance>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_onCompleteWithClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x060089FA RID: 35322 RVA: 0x002430A8 File Offset: 0x002412A8
		// (set) Token: 0x060089FB RID: 35323 RVA: 0x00041FB4 File Offset: 0x000401B4
		public unsafe Dictionary<string, ClothingDefinition> lastSelectedClothingDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ClothingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_lastSelectedClothingDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x060089FC RID: 35324 RVA: 0x002430D8 File Offset: 0x002412D8
		// (set) Token: 0x060089FD RID: 35325 RVA: 0x00041FD3 File Offset: 0x000401D3
		public unsafe float rigTargetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x04005D82 RID: 23938
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005D83 RID: 23939
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04005D84 RID: 23940
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSettings_k__BackingField;

		// Token: 0x04005D85 RID: 23941
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005D86 RID: 23942
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005D87 RID: 23943
		private static readonly IntPtr NativeFieldInfoPtr_RigContainer;

		// Token: 0x04005D88 RID: 23944
		private static readonly IntPtr NativeFieldInfoPtr_Rig;

		// Token: 0x04005D89 RID: 23945
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005D8A RID: 23946
		private static readonly IntPtr NativeFieldInfoPtr_CanvasAnimation;

		// Token: 0x04005D8B RID: 23947
		private static readonly IntPtr NativeFieldInfoPtr_DemoCreator;

		// Token: 0x04005D8C RID: 23948
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005D8D RID: 23949
		private static readonly IntPtr NativeFieldInfoPtr_Presets;

		// Token: 0x04005D8E RID: 23950
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04005D8F RID: 23951
		private static readonly IntPtr NativeFieldInfoPtr_onCompleteWithClothing;

		// Token: 0x04005D90 RID: 23952
		private static readonly IntPtr NativeFieldInfoPtr_lastSelectedClothingDefinitions;

		// Token: 0x04005D91 RID: 23953
		private static readonly IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04005D92 RID: 23954
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005D93 RID: 23955
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005D94 RID: 23956
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x04005D95 RID: 23957
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04005D96 RID: 23958
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005D97 RID: 23959
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005D98 RID: 23960
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005D99 RID: 23961
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04005D9A RID: 23962
		private static readonly IntPtr NativeMethodInfoPtr_ShowUI_Public_Void_0;

		// Token: 0x04005D9B RID: 23963
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005D9C RID: 23964
		private static readonly IntPtr NativeMethodInfoPtr_DisableStuff_Public_Void_0;

		// Token: 0x04005D9D RID: 23965
		private static readonly IntPtr NativeMethodInfoPtr_Done_Public_Void_0;

		// Token: 0x04005D9E RID: 23966
		private static readonly IntPtr NativeMethodInfoPtr_SliderChanged_Public_Void_Single_0;

		// Token: 0x04005D9F RID: 23967
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0;

		// Token: 0x04005DA0 RID: 23968
		private static readonly IntPtr NativeMethodInfoPtr_SelectPreset_Public_Void_String_0;

		// Token: 0x04005DA1 RID: 23969
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCategory_Public_Void_ECategory_0;

		// Token: 0x04005DA2 RID: 23970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005DA3 RID: 23971
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B0B RID: 2827
		[OriginalName("Assembly-CSharp.dll", "", "ECategory")]
		public enum ECategory
		{
			// Token: 0x04009038 RID: 36920
			Body,
			// Token: 0x04009039 RID: 36921
			Hair,
			// Token: 0x0400903A RID: 36922
			Face,
			// Token: 0x0400903B RID: 36923
			Eyes,
			// Token: 0x0400903C RID: 36924
			Eyebrows,
			// Token: 0x0400903D RID: 36925
			Clothing,
			// Token: 0x0400903E RID: 36926
			Accessories
		}

		// Token: 0x02000B0C RID: 2828
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<<Close>g__Close|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D676 RID: 54902 RVA: 0x00330C5C File Offset: 0x0032EE5C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique()
			{
				Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<<Close>g__Close|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>1__state");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>2__current");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, "<>4__this");
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680438);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680439);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680440);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680441);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680442);
				CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr, 100680443);
			}

			// Token: 0x0600D677 RID: 54903 RVA: 0x00330D3C File Offset: 0x0032EF3C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D678 RID: 54904 RVA: 0x00330D84 File Offset: 0x0032EF84
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D679 RID: 54905 RVA: 0x00330DB8 File Offset: 0x0032EFB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253479, XrefRangeEnd = 253494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004276 RID: 17014
			// (get) Token: 0x0600D67A RID: 54906 RVA: 0x00330DF4 File Offset: 0x0032EFF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D67B RID: 54907 RVA: 0x00330E34 File Offset: 0x0032F034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253494, XrefRangeEnd = 253499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004277 RID: 17015
			// (get) Token: 0x0600D67C RID: 54908 RVA: 0x00330E68 File Offset: 0x0032F068
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D67D RID: 54909 RVA: 0x000685FA File Offset: 0x000667FA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004273 RID: 17011
			// (get) Token: 0x0600D67E RID: 54910 RVA: 0x00330EA8 File Offset: 0x0032F0A8
			// (set) Token: 0x0600D67F RID: 54911 RVA: 0x00068603 File Offset: 0x00066803
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004274 RID: 17012
			// (get) Token: 0x0600D680 RID: 54912 RVA: 0x00330ED0 File Offset: 0x0032F0D0
			// (set) Token: 0x0600D681 RID: 54913 RVA: 0x0006861E File Offset: 0x0006681E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004275 RID: 17013
			// (get) Token: 0x0600D682 RID: 54914 RVA: 0x00330F00 File Offset: 0x0032F100
			// (set) Token: 0x0600D683 RID: 54915 RVA: 0x0006863D File Offset: 0x0006683D
			public unsafe CharacterCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400903F RID: 36927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009040 RID: 36928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009041 RID: 36929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009042 RID: 36930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009043 RID: 36931
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009044 RID: 36932
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009045 RID: 36933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009046 RID: 36934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009047 RID: 36935
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B0D RID: 2829
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.CharacterCreator+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D684 RID: 54916 RVA: 0x00330F30 File Offset: 0x0032F130
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr);
				CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, "presetName");
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680444);
				CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr, 100680445);
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x00330F98 File Offset: 0x0032F198
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreator.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D686 RID: 54918 RVA: 0x00330FD4 File Offset: 0x0032F1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253499, XrefRangeEnd = 253502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectPreset_b__0(BasicAvatarSettings p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreator.__c__DisplayClass33_0.NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D687 RID: 54919 RVA: 0x0006865C File Offset: 0x0006685C
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004278 RID: 17016
			// (get) Token: 0x0600D688 RID: 54920 RVA: 0x00331024 File Offset: 0x0032F224
			// (set) Token: 0x0600D689 RID: 54921 RVA: 0x00068665 File Offset: 0x00066865
			public unsafe string presetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreator.__c__DisplayClass33_0.NativeFieldInfoPtr_presetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009048 RID: 36936
			private static readonly IntPtr NativeFieldInfoPtr_presetName;

			// Token: 0x04009049 RID: 36937
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400904A RID: 36938
			private static readonly IntPtr NativeMethodInfoPtr__SelectPreset_b__0_Internal_Boolean_BasicAvatarSettings_0;
		}

		// Token: 0x02000B0E RID: 2830
		private sealed class MethodInfoStoreGeneric_SetValue_Public_T_String_T_ClothingDefinition_0<T>
		{
			// Token: 0x0400904B RID: 36939
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterCreator.NativeMethodInfoPtr_SetValue_Public_T_String_T_ClothingDefinition_0, Il2CppClassPointerStore<CharacterCreator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
