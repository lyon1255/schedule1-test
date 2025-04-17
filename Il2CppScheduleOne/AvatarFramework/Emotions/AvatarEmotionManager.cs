using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000606 RID: 1542
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x060087E1 RID: 34785 RVA: 0x0023CEE4 File Offset: 0x0023B0E4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionManager()
		{
			Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr);
			AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "MAX_UPDATE_DISTANCE");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotion>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotionPreset>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EmotionPresetList");
			AvatarEmotionManager.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "Avatar");
			AvatarEmotionManager.NativeFieldInfoPtr_EyeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyeController");
			AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyebrowController");
			AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "activeEmotionOverride");
			AvatarEmotionManager.NativeFieldInfoPtr_overrideStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "overrideStack");
			AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "neutralPreset");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionLerpRoutine");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionRemovalRoutines");
			AvatarEmotionManager.NativeFieldInfoPtr_tempIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "tempIndex");
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680231);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680232);
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680233);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680234);
			AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680235);
			AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680236);
			AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680237);
			AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680238);
			AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680239);
			AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680240);
			AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680241);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680242);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680243);
			AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680244);
			AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680245);
			AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680246);
			AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680247);
			AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680248);
			AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680249);
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x060087E2 RID: 34786 RVA: 0x0023D194 File Offset: 0x0023B394
		// (set) Token: 0x060087E3 RID: 34787 RVA: 0x0023D1CC File Offset: 0x0023B3CC
		public unsafe string CurrentEmotion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x0023D210 File Offset: 0x0023B410
		// (set) Token: 0x060087E5 RID: 34789 RVA: 0x0023D250 File Offset: 0x0023B450
		public unsafe AvatarEmotionPreset CurrentEmotionPreset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x060087E6 RID: 34790 RVA: 0x0023D294 File Offset: 0x0023B494
		public unsafe bool IsSwitchingEmotion
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 251692, RefRangeEnd = 251695, XrefRangeStart = 251692, XrefRangeEnd = 251692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x0023D2D0 File Offset: 0x0023B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251695, XrefRangeEnd = 251721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x0023D304 File Offset: 0x0023B504
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x0023D338 File Offset: 0x0023B538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251721, XrefRangeEnd = 251781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEmotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x0023D36C File Offset: 0x0023B56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251804, RefRangeEnd = 251806, XrefRangeStart = 251781, XrefRangeEnd = 251804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(faceTex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftEyelidConfig;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightEyelidConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x0023D3E8 File Offset: 0x0023B5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251806, XrefRangeEnd = 251849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotionName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x0023D464 File Offset: 0x0023B664
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 251867, RefRangeEnd = 251890, XrefRangeStart = 251849, XrefRangeEnd = 251867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEmotionOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x0023D4A8 File Offset: 0x0023B6A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251898, RefRangeEnd = 251900, XrefRangeStart = 251890, XrefRangeEnd = 251898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x0023D4DC File Offset: 0x0023B6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251913, RefRangeEnd = 251915, XrefRangeStart = 251900, XrefRangeEnd = 251913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRemovalRoutine(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x0023D520 File Offset: 0x0023B720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251915, XrefRangeEnd = 251939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride GetHighestPriorityOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr3) : null;
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x0023D560 File Offset: 0x0023B760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251939, XrefRangeEnd = 251957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x0023D5B0 File Offset: 0x0023B7B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251981, RefRangeEnd = 251984, XrefRangeStart = 251957, XrefRangeEnd = 251981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmotion(AvatarEmotionPreset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x0023D5F4 File Offset: 0x0023B7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251985, RefRangeEnd = 251986, XrefRangeStart = 251984, XrefRangeEnd = 251985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x0023D644 File Offset: 0x0023B844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252001, RefRangeEnd = 252003, XrefRangeStart = 251986, XrefRangeEnd = 252001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset GetEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x0023D694 File Offset: 0x0023B894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252003, XrefRangeEnd = 252029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x00040C14 File Offset: 0x0003EE14
		public AvatarEmotionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x060087F6 RID: 34806 RVA: 0x0023D6D0 File Offset: 0x0023B8D0
		// (set) Token: 0x060087F7 RID: 34807 RVA: 0x00040C1D File Offset: 0x0003EE1D
		public unsafe static float MAX_UPDATE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x060087F8 RID: 34808 RVA: 0x0023D6EC File Offset: 0x0023B8EC
		// (set) Token: 0x060087F9 RID: 34809 RVA: 0x00040C2B File Offset: 0x0003EE2B
		public unsafe string _CurrentEmotion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x0023D714 File Offset: 0x0023B914
		// (set) Token: 0x060087FB RID: 34811 RVA: 0x00040C4A File Offset: 0x0003EE4A
		public unsafe AvatarEmotionPreset _CurrentEmotionPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x060087FC RID: 34812 RVA: 0x0023D744 File Offset: 0x0023B944
		// (set) Token: 0x060087FD RID: 34813 RVA: 0x00040C69 File Offset: 0x0003EE69
		public unsafe List<AvatarEmotionPreset> EmotionPresetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarEmotionPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x060087FE RID: 34814 RVA: 0x0023D774 File Offset: 0x0023B974
		// (set) Token: 0x060087FF RID: 34815 RVA: 0x00040C88 File Offset: 0x0003EE88
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x06008800 RID: 34816 RVA: 0x0023D7A4 File Offset: 0x0023B9A4
		// (set) Token: 0x06008801 RID: 34817 RVA: 0x00040CA7 File Offset: 0x0003EEA7
		public unsafe EyeController EyeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x06008802 RID: 34818 RVA: 0x0023D7D4 File Offset: 0x0023B9D4
		// (set) Token: 0x06008803 RID: 34819 RVA: 0x00040CC6 File Offset: 0x0003EEC6
		public unsafe EyebrowController EyebrowController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x06008804 RID: 34820 RVA: 0x0023D804 File Offset: 0x0023BA04
		// (set) Token: 0x06008805 RID: 34821 RVA: 0x00040CE5 File Offset: 0x0003EEE5
		public unsafe EmotionOverride activeEmotionOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x06008806 RID: 34822 RVA: 0x0023D834 File Offset: 0x0023BA34
		// (set) Token: 0x06008807 RID: 34823 RVA: 0x00040D04 File Offset: 0x0003EF04
		public unsafe List<EmotionOverride> overrideStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmotionOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06008808 RID: 34824 RVA: 0x0023D864 File Offset: 0x0023BA64
		// (set) Token: 0x06008809 RID: 34825 RVA: 0x00040D23 File Offset: 0x0003EF23
		public unsafe AvatarEmotionPreset neutralPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x0600880A RID: 34826 RVA: 0x0023D894 File Offset: 0x0023BA94
		// (set) Token: 0x0600880B RID: 34827 RVA: 0x00040D42 File Offset: 0x0003EF42
		public unsafe Coroutine emotionLerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600880C RID: 34828 RVA: 0x0023D8C4 File Offset: 0x0023BAC4
		// (set) Token: 0x0600880D RID: 34829 RVA: 0x00040D61 File Offset: 0x0003EF61
		public unsafe Dictionary<string, Coroutine> emotionRemovalRoutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600880E RID: 34830 RVA: 0x0023D8F4 File Offset: 0x0023BAF4
		// (set) Token: 0x0600880F RID: 34831 RVA: 0x00040D80 File Offset: 0x0003EF80
		public unsafe int tempIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex)) = value;
			}
		}

		// Token: 0x04005C5B RID: 23643
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UPDATE_DISTANCE;

		// Token: 0x04005C5C RID: 23644
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotion_k__BackingField;

		// Token: 0x04005C5D RID: 23645
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField;

		// Token: 0x04005C5E RID: 23646
		private static readonly IntPtr NativeFieldInfoPtr_EmotionPresetList;

		// Token: 0x04005C5F RID: 23647
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005C60 RID: 23648
		private static readonly IntPtr NativeFieldInfoPtr_EyeController;

		// Token: 0x04005C61 RID: 23649
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowController;

		// Token: 0x04005C62 RID: 23650
		private static readonly IntPtr NativeFieldInfoPtr_activeEmotionOverride;

		// Token: 0x04005C63 RID: 23651
		private static readonly IntPtr NativeFieldInfoPtr_overrideStack;

		// Token: 0x04005C64 RID: 23652
		private static readonly IntPtr NativeFieldInfoPtr_neutralPreset;

		// Token: 0x04005C65 RID: 23653
		private static readonly IntPtr NativeFieldInfoPtr_emotionLerpRoutine;

		// Token: 0x04005C66 RID: 23654
		private static readonly IntPtr NativeFieldInfoPtr_emotionRemovalRoutines;

		// Token: 0x04005C67 RID: 23655
		private static readonly IntPtr NativeFieldInfoPtr_tempIndex;

		// Token: 0x04005C68 RID: 23656
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0;

		// Token: 0x04005C69 RID: 23657
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0;

		// Token: 0x04005C6A RID: 23658
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0;

		// Token: 0x04005C6B RID: 23659
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0;

		// Token: 0x04005C6C RID: 23660
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0;

		// Token: 0x04005C6D RID: 23661
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005C6E RID: 23662
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005C6F RID: 23663
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEmotion_Public_Void_0;

		// Token: 0x04005C70 RID: 23664
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0;

		// Token: 0x04005C71 RID: 23665
		private static readonly IntPtr NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0;

		// Token: 0x04005C72 RID: 23666
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0;

		// Token: 0x04005C73 RID: 23667
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrides_Public_Void_0;

		// Token: 0x04005C74 RID: 23668
		private static readonly IntPtr NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0;

		// Token: 0x04005C75 RID: 23669
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0;

		// Token: 0x04005C76 RID: 23670
		private static readonly IntPtr NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0;

		// Token: 0x04005C77 RID: 23671
		private static readonly IntPtr NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0;

		// Token: 0x04005C78 RID: 23672
		private static readonly IntPtr NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0;

		// Token: 0x04005C79 RID: 23673
		private static readonly IntPtr NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0;

		// Token: 0x04005C7A RID: 23674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AFB RID: 2811
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D60B RID: 54795 RVA: 0x0032F990 File Offset: 0x0032DB90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr);
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__21_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__24_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__29_0");
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680251);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680252);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680253);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680254);
			}

			// Token: 0x0600D60C RID: 54796 RVA: 0x0032FA5C File Offset: 0x0032DC5C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D60D RID: 54797 RVA: 0x0032FA98 File Offset: 0x0032DC98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251646, XrefRangeEnd = 251650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__21_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D60E RID: 54798 RVA: 0x0032FAE8 File Offset: 0x0032DCE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251650, XrefRangeEnd = 251654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConfigureNeutralFace_b__24_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D60F RID: 54799 RVA: 0x0032FB38 File Offset: 0x0032DD38
			[CallerCount(0)]
			public unsafe int _GetHighestPriorityOverride_b__29_0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D610 RID: 54800 RVA: 0x000682B7 File Offset: 0x000664B7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004258 RID: 16984
			// (get) Token: 0x0600D611 RID: 54801 RVA: 0x0032FB88 File Offset: 0x0032DD88
			// (set) Token: 0x0600D612 RID: 54802 RVA: 0x000682C0 File Offset: 0x000664C0
			public unsafe static AvatarEmotionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004259 RID: 16985
			// (get) Token: 0x0600D613 RID: 54803 RVA: 0x0032FBB0 File Offset: 0x0032DDB0
			// (set) Token: 0x0600D614 RID: 54804 RVA: 0x000682D2 File Offset: 0x000664D2
			public unsafe static Predicate<AvatarEmotionPreset> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425A RID: 16986
			// (get) Token: 0x0600D615 RID: 54805 RVA: 0x0032FBD8 File Offset: 0x0032DDD8
			// (set) Token: 0x0600D616 RID: 54806 RVA: 0x000682E4 File Offset: 0x000664E4
			public unsafe static Predicate<AvatarEmotionPreset> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700425B RID: 16987
			// (get) Token: 0x0600D617 RID: 54807 RVA: 0x0032FC00 File Offset: 0x0032DE00
			// (set) Token: 0x0600D618 RID: 54808 RVA: 0x000682F6 File Offset: 0x000664F6
			public unsafe static Func<EmotionOverride, int> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EmotionOverride, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FF7 RID: 36855
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008FF8 RID: 36856
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04008FF9 RID: 36857
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04008FFA RID: 36858
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04008FFB RID: 36859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FFC RID: 36860
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x04008FFD RID: 36861
			private static readonly IntPtr NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x04008FFE RID: 36862
			private static readonly IntPtr NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0;
		}

		// Token: 0x02000AFC RID: 2812
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D619 RID: 54809 RVA: 0x0032FC28 File Offset: 0x0032DE28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "overrideLabel");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "duration");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680255);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680256);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680257);
			}

			// Token: 0x0600D61A RID: 54810 RVA: 0x0032FCCC File Offset: 0x0032DECC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D61B RID: 54811 RVA: 0x0032FD08 File Offset: 0x0032DF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D61C RID: 54812 RVA: 0x0032FD58 File Offset: 0x0032DF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251664, XrefRangeEnd = 251669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D61D RID: 54813 RVA: 0x00068308 File Offset: 0x00066508
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425C RID: 16988
			// (get) Token: 0x0600D61E RID: 54814 RVA: 0x0032FD98 File Offset: 0x0032DF98
			// (set) Token: 0x0600D61F RID: 54815 RVA: 0x00068311 File Offset: 0x00066511
			public unsafe string overrideLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700425D RID: 16989
			// (get) Token: 0x0600D620 RID: 54816 RVA: 0x0032FDC0 File Offset: 0x0032DFC0
			// (set) Token: 0x0600D621 RID: 54817 RVA: 0x00068330 File Offset: 0x00066530
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700425E RID: 16990
			// (get) Token: 0x0600D622 RID: 54818 RVA: 0x0032FDE8 File Offset: 0x0032DFE8
			// (set) Token: 0x0600D623 RID: 54819 RVA: 0x0006834B File Offset: 0x0006654B
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FFF RID: 36863
			private static readonly IntPtr NativeFieldInfoPtr_overrideLabel;

			// Token: 0x04009000 RID: 36864
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009001 RID: 36865
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009002 RID: 36866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009003 RID: 36867
			private static readonly IntPtr NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;

			// Token: 0x04009004 RID: 36868
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C69 RID: 3177
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0+<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E49F RID: 58527 RVA: 0x00359948 File Offset: 0x00357B48
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680258);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680259);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680260);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680261);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680262);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680263);
				}

				// Token: 0x0600E4A0 RID: 58528 RVA: 0x00359A28 File Offset: 0x00357C28
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4A1 RID: 58529 RVA: 0x00359A70 File Offset: 0x00357C70
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4A2 RID: 58530 RVA: 0x00359AA4 File Offset: 0x00357CA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251654, XrefRangeEnd = 251659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004708 RID: 18184
				// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x00359AE0 File Offset: 0x00357CE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4A4 RID: 58532 RVA: 0x00359B20 File Offset: 0x00357D20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251659, XrefRangeEnd = 251664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004709 RID: 18185
				// (get) Token: 0x0600E4A5 RID: 58533 RVA: 0x00359B54 File Offset: 0x00357D54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4A6 RID: 58534 RVA: 0x0006F779 File Offset: 0x0006D979
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004705 RID: 18181
				// (get) Token: 0x0600E4A7 RID: 58535 RVA: 0x00359B94 File Offset: 0x00357D94
				// (set) Token: 0x0600E4A8 RID: 58536 RVA: 0x0006F782 File Offset: 0x0006D982
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004706 RID: 18182
				// (get) Token: 0x0600E4A9 RID: 58537 RVA: 0x00359BBC File Offset: 0x00357DBC
				// (set) Token: 0x0600E4AA RID: 58538 RVA: 0x0006F79D File Offset: 0x0006D99D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004707 RID: 18183
				// (get) Token: 0x0600E4AB RID: 58539 RVA: 0x00359BEC File Offset: 0x00357DEC
				// (set) Token: 0x0600E4AC RID: 58540 RVA: 0x0006F7BC File Offset: 0x0006D9BC
				public unsafe AvatarEmotionManager.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040098EB RID: 39147
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098EC RID: 39148
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098ED RID: 39149
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098EE RID: 39150
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098EF RID: 39151
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098F0 RID: 39152
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098F1 RID: 39153
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098F2 RID: 39154
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098F3 RID: 39155
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AFD RID: 2813
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D624 RID: 54820 RVA: 0x0032FE18 File Offset: 0x0032E018
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, "label");
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680264);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680265);
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x0032FE80 File Offset: 0x0032E080
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x0032FEBC File Offset: 0x0032E0BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x0006836A File Offset: 0x0006656A
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425F RID: 16991
			// (get) Token: 0x0600D628 RID: 54824 RVA: 0x0032FF0C File Offset: 0x0032E10C
			// (set) Token: 0x0600D629 RID: 54825 RVA: 0x00068373 File Offset: 0x00066573
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009005 RID: 36869
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009006 RID: 36870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009007 RID: 36871
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;
		}

		// Token: 0x02000AFE RID: 2814
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D62A RID: 54826 RVA: 0x0032FF34 File Offset: 0x0032E134
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "preset");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "animationTime");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680266);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680267);
			}

			// Token: 0x0600D62B RID: 54827 RVA: 0x0032FFC4 File Offset: 0x0032E1C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D62C RID: 54828 RVA: 0x00330000 File Offset: 0x0032E200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251687, XrefRangeEnd = 251692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D62D RID: 54829 RVA: 0x00068392 File Offset: 0x00066592
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004260 RID: 16992
			// (get) Token: 0x0600D62E RID: 54830 RVA: 0x00330040 File Offset: 0x0032E240
			// (set) Token: 0x0600D62F RID: 54831 RVA: 0x0006839B File Offset: 0x0006659B
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004261 RID: 16993
			// (get) Token: 0x0600D630 RID: 54832 RVA: 0x00330070 File Offset: 0x0032E270
			// (set) Token: 0x0600D631 RID: 54833 RVA: 0x000683BA File Offset: 0x000665BA
			public unsafe AvatarEmotionPreset preset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004262 RID: 16994
			// (get) Token: 0x0600D632 RID: 54834 RVA: 0x003300A0 File Offset: 0x0032E2A0
			// (set) Token: 0x0600D633 RID: 54835 RVA: 0x000683D9 File Offset: 0x000665D9
			public unsafe float animationTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime)) = value;
				}
			}

			// Token: 0x04009008 RID: 36872
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009009 RID: 36873
			private static readonly IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x0400900A RID: 36874
			private static readonly IntPtr NativeFieldInfoPtr_animationTime;

			// Token: 0x0400900B RID: 36875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400900C RID: 36876
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C6A RID: 3178
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0+<<LerpEmotion>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E4AD RID: 58541 RVA: 0x00359C1C File Offset: 0x00357E1C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<<LerpEmotion>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<startPreset>5__2");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<timeStep>5__3");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680268);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680269);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680270);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680271);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680272);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680273);
				}

				// Token: 0x0600E4AE RID: 58542 RVA: 0x00359D38 File Offset: 0x00357F38
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4AF RID: 58543 RVA: 0x00359D80 File Offset: 0x00357F80
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E4B0 RID: 58544 RVA: 0x00359DB4 File Offset: 0x00357FB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251669, XrefRangeEnd = 251682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004710 RID: 18192
				// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x00359DF0 File Offset: 0x00357FF0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4B2 RID: 58546 RVA: 0x00359E30 File Offset: 0x00358030
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251682, XrefRangeEnd = 251687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004711 RID: 18193
				// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x00359E64 File Offset: 0x00358064
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E4B4 RID: 58548 RVA: 0x0006F7DB File Offset: 0x0006D9DB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700470A RID: 18186
				// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x00359EA4 File Offset: 0x003580A4
				// (set) Token: 0x0600E4B6 RID: 58550 RVA: 0x0006F7E4 File Offset: 0x0006D9E4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700470B RID: 18187
				// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x00359ECC File Offset: 0x003580CC
				// (set) Token: 0x0600E4B8 RID: 58552 RVA: 0x0006F7FF File Offset: 0x0006D9FF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700470C RID: 18188
				// (get) Token: 0x0600E4B9 RID: 58553 RVA: 0x00359EFC File Offset: 0x003580FC
				// (set) Token: 0x0600E4BA RID: 58554 RVA: 0x0006F81E File Offset: 0x0006DA1E
				public unsafe AvatarEmotionManager.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700470D RID: 18189
				// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x00359F2C File Offset: 0x0035812C
				// (set) Token: 0x0600E4BC RID: 58556 RVA: 0x0006F83D File Offset: 0x0006DA3D
				public unsafe AvatarEmotionPreset _startPreset_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700470E RID: 18190
				// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x00359F5C File Offset: 0x0035815C
				// (set) Token: 0x0600E4BE RID: 58558 RVA: 0x0006F85C File Offset: 0x0006DA5C
				public unsafe float _timeStep_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3)) = value;
					}
				}

				// Token: 0x1700470F RID: 18191
				// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x00359F84 File Offset: 0x00358184
				// (set) Token: 0x0600E4C0 RID: 58560 RVA: 0x0006F877 File Offset: 0x0006DA77
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040098F4 RID: 39156
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040098F5 RID: 39157
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040098F6 RID: 39158
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040098F7 RID: 39159
				private static readonly IntPtr NativeFieldInfoPtr__startPreset_5__2;

				// Token: 0x040098F8 RID: 39160
				private static readonly IntPtr NativeFieldInfoPtr__timeStep_5__3;

				// Token: 0x040098F9 RID: 39161
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040098FA RID: 39162
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040098FB RID: 39163
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098FC RID: 39164
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040098FD RID: 39165
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040098FE RID: 39166
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040098FF RID: 39167
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AFF RID: 2815
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D634 RID: 54836 RVA: 0x003300C8 File Offset: 0x0032E2C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, "emotion");
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680274);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680275);
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x00330130 File Offset: 0x0032E330
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D636 RID: 54838 RVA: 0x0033016C File Offset: 0x0032E36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEmotion_b__0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D637 RID: 54839 RVA: 0x000683F4 File Offset: 0x000665F4
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004263 RID: 16995
			// (get) Token: 0x0600D638 RID: 54840 RVA: 0x003301BC File Offset: 0x0032E3BC
			// (set) Token: 0x0600D639 RID: 54841 RVA: 0x000683FD File Offset: 0x000665FD
			public unsafe string emotion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400900D RID: 36877
			private static readonly IntPtr NativeFieldInfoPtr_emotion;

			// Token: 0x0400900E RID: 36878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400900F RID: 36879
			private static readonly IntPtr NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0;
		}
	}
}
