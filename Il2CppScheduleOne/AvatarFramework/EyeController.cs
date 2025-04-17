using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F7 RID: 1527
	public class EyeController : MonoBehaviour
	{
		// Token: 0x06008680 RID: 34432 RVA: 0x00239290 File Offset: 0x00237490
		// Note: this type is marked as 'beforefieldinit'.
		static EyeController()
		{
			Il2CppClassPointerStore<EyeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController>.NativeClassPtr);
			EyeController.NativeFieldInfoPtr_eyeHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeightMultiplier");
			EyeController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "DEBUG");
			EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<EyesOpen>k__BackingField");
			EyeController.NativeFieldInfoPtr_leftEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEye");
			EyeController.NativeFieldInfoPtr_rightEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEye");
			EyeController.NativeFieldInfoPtr_eyeSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSpacing");
			EyeController.NativeFieldInfoPtr_eyeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeight");
			EyeController.NativeFieldInfoPtr_eyeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSize");
			EyeController.NativeFieldInfoPtr_leftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEyeLidColor");
			EyeController.NativeFieldInfoPtr_rightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEyeLidColor");
			EyeController.NativeFieldInfoPtr_LeftRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "LeftRestingEyeState");
			EyeController.NativeFieldInfoPtr_RightRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "RightRestingEyeState");
			EyeController.NativeFieldInfoPtr_eyeBallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallMaterial");
			EyeController.NativeFieldInfoPtr_eyeBallColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallColor");
			EyeController.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "PupilDilation");
			EyeController.NativeFieldInfoPtr_BlinkingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "BlinkingEnabled");
			EyeController.NativeFieldInfoPtr_blinkInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkInterval");
			EyeController.NativeFieldInfoPtr_blinkIntervalSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkIntervalSpread");
			EyeController.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkDuration");
			EyeController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "avatar");
			EyeController.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkRoutine");
			EyeController.NativeFieldInfoPtr_timeUntilNextBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "timeUntilNextBlink");
			EyeController.NativeFieldInfoPtr_eyeBallTintOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallTintOverridden");
			EyeController.NativeFieldInfoPtr_eyeLidOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeLidOverridden");
			EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultLeftEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultRightEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultDilation");
			EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680096);
			EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680097);
			EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680098);
			EyeController.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680099);
			EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680100);
			EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680101);
			EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680102);
			EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680103);
			EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680104);
			EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680105);
			EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680106);
			EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680107);
			EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680108);
			EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680109);
			EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680110);
			EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680111);
			EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680112);
			EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680113);
			EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680114);
			EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680115);
			EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680116);
			EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680117);
			EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680118);
			EyeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680119);
			EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680121);
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06008681 RID: 34433 RVA: 0x002396D0 File Offset: 0x002378D0
		// (set) Token: 0x06008682 RID: 34434 RVA: 0x0023970C File Offset: 0x0023790C
		public unsafe bool EyesOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x0023974C File Offset: 0x0023794C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250777, XrefRangeEnd = 250794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x00239788 File Offset: 0x00237988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250794, XrefRangeEnd = 250809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x002397BC File Offset: 0x002379BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250809, XrefRangeEnd = 250810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x002397F0 File Offset: 0x002379F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250810, XrefRangeEnd = 250839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x00239824 File Offset: 0x00237A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250839, XrefRangeEnd = 250841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x00239864 File Offset: 0x00237A64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250843, RefRangeEnd = 250849, XrefRangeStart = 250841, XrefRangeEnd = 250843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x002398A4 File Offset: 0x00237AA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250851, RefRangeEnd = 250857, XrefRangeStart = 250849, XrefRangeEnd = 250851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballTint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x002398D8 File Offset: 0x00237AD8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 250857, RefRangeEnd = 250866, XrefRangeStart = 250857, XrefRangeEnd = 250857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeLidConfiguration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00239918 File Offset: 0x00237B18
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 250866, RefRangeEnd = 250878, XrefRangeStart = 250866, XrefRangeEnd = 250866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeLids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x0023994C File Offset: 0x00237B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250878, XrefRangeEnd = 250881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x002399A8 File Offset: 0x00237BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250896, RefRangeEnd = 250898, XrefRangeStart = 250881, XrefRangeEnd = 250896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyesOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x002399E8 File Offset: 0x00237BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250898, XrefRangeEnd = 250901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x00239A1C File Offset: 0x00237C1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250903, RefRangeEnd = 250909, XrefRangeStart = 250901, XrefRangeEnd = 250903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPupilDilation(float dilation, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x00239A68 File Offset: 0x00237C68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250911, RefRangeEnd = 250917, XrefRangeStart = 250909, XrefRangeEnd = 250911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPupilDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x00239A9C File Offset: 0x00237C9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250920, RefRangeEnd = 250922, XrefRangeStart = 250917, XrefRangeEnd = 250920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRestingEyeLidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x00239AD0 File Offset: 0x00237CD0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 250925, RefRangeEnd = 250948, XrefRangeStart = 250922, XrefRangeEnd = 250925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x00239B04 File Offset: 0x00237D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250948, XrefRangeEnd = 250949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x00239B44 File Offset: 0x00237D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250949, XrefRangeEnd = 250950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref config;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x00239B84 File Offset: 0x00237D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250950, XrefRangeEnd = 250955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlinkRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x00239BC4 File Offset: 0x00237DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250955, XrefRangeEnd = 250956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBlinkCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x00239BF8 File Offset: 0x00237DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250958, RefRangeEnd = 250959, XrefRangeStart = 250956, XrefRangeEnd = 250958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x00239C44 File Offset: 0x00237E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250959, XrefRangeEnd = 250960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x00239C80 File Offset: 0x00237E80
		[CallerCount(0)]
		public unsafe bool _BlinkRoutine_b__48_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x0003FF01 File Offset: 0x0003E101
		public EyeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028DE RID: 10462
		// (get) Token: 0x0600869B RID: 34459 RVA: 0x00239CBC File Offset: 0x00237EBC
		// (set) Token: 0x0600869C RID: 34460 RVA: 0x0003FF0A File Offset: 0x0003E10A
		public unsafe static float eyeHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170028DF RID: 10463
		// (get) Token: 0x0600869D RID: 34461 RVA: 0x00239CD8 File Offset: 0x00237ED8
		// (set) Token: 0x0600869E RID: 34462 RVA: 0x0003FF18 File Offset: 0x0003E118
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170028E0 RID: 10464
		// (get) Token: 0x0600869F RID: 34463 RVA: 0x00239D00 File Offset: 0x00237F00
		// (set) Token: 0x060086A0 RID: 34464 RVA: 0x0003FF33 File Offset: 0x0003E133
		public unsafe bool _EyesOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170028E1 RID: 10465
		// (get) Token: 0x060086A1 RID: 34465 RVA: 0x00239D28 File Offset: 0x00237F28
		// (set) Token: 0x060086A2 RID: 34466 RVA: 0x0003FF4E File Offset: 0x0003E14E
		public unsafe Eye leftEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E2 RID: 10466
		// (get) Token: 0x060086A3 RID: 34467 RVA: 0x00239D58 File Offset: 0x00237F58
		// (set) Token: 0x060086A4 RID: 34468 RVA: 0x0003FF6D File Offset: 0x0003E16D
		public unsafe Eye rightEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028E3 RID: 10467
		// (get) Token: 0x060086A5 RID: 34469 RVA: 0x00239D88 File Offset: 0x00237F88
		// (set) Token: 0x060086A6 RID: 34470 RVA: 0x0003FF8C File Offset: 0x0003E18C
		public unsafe float eyeSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing)) = value;
			}
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x060086A7 RID: 34471 RVA: 0x00239DB0 File Offset: 0x00237FB0
		// (set) Token: 0x060086A8 RID: 34472 RVA: 0x0003FFA7 File Offset: 0x0003E1A7
		public unsafe float eyeHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight)) = value;
			}
		}

		// Token: 0x170028E5 RID: 10469
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x00239DD8 File Offset: 0x00237FD8
		// (set) Token: 0x060086AA RID: 34474 RVA: 0x0003FFC2 File Offset: 0x0003E1C2
		public unsafe float eyeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize)) = value;
			}
		}

		// Token: 0x170028E6 RID: 10470
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x00239E00 File Offset: 0x00238000
		// (set) Token: 0x060086AC RID: 34476 RVA: 0x0003FFDD File Offset: 0x0003E1DD
		public unsafe Color leftEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor)) = value;
			}
		}

		// Token: 0x170028E7 RID: 10471
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x00239E28 File Offset: 0x00238028
		// (set) Token: 0x060086AE RID: 34478 RVA: 0x0003FFF8 File Offset: 0x0003E1F8
		public unsafe Color rightEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor)) = value;
			}
		}

		// Token: 0x170028E8 RID: 10472
		// (get) Token: 0x060086AF RID: 34479 RVA: 0x00239E50 File Offset: 0x00238050
		// (set) Token: 0x060086B0 RID: 34480 RVA: 0x00040013 File Offset: 0x0003E213
		public unsafe Eye.EyeLidConfiguration LeftRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState)) = value;
			}
		}

		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x060086B1 RID: 34481 RVA: 0x00239E78 File Offset: 0x00238078
		// (set) Token: 0x060086B2 RID: 34482 RVA: 0x0004002E File Offset: 0x0003E22E
		public unsafe Eye.EyeLidConfiguration RightRestingEyeState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState)) = value;
			}
		}

		// Token: 0x170028EA RID: 10474
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x00239EA0 File Offset: 0x002380A0
		// (set) Token: 0x060086B4 RID: 34484 RVA: 0x00040049 File Offset: 0x0003E249
		public unsafe Material eyeBallMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028EB RID: 10475
		// (get) Token: 0x060086B5 RID: 34485 RVA: 0x00239ED0 File Offset: 0x002380D0
		// (set) Token: 0x060086B6 RID: 34486 RVA: 0x00040068 File Offset: 0x0003E268
		public unsafe Color eyeBallColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor)) = value;
			}
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x060086B7 RID: 34487 RVA: 0x00239EF8 File Offset: 0x002380F8
		// (set) Token: 0x060086B8 RID: 34488 RVA: 0x00040083 File Offset: 0x0003E283
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x00239F20 File Offset: 0x00238120
		// (set) Token: 0x060086BA RID: 34490 RVA: 0x0004009E File Offset: 0x0003E29E
		public unsafe bool BlinkingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled)) = value;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x00239F48 File Offset: 0x00238148
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x000400B9 File Offset: 0x0003E2B9
		public unsafe float blinkInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval)) = value;
			}
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x00239F70 File Offset: 0x00238170
		// (set) Token: 0x060086BE RID: 34494 RVA: 0x000400D4 File Offset: 0x0003E2D4
		public unsafe float blinkIntervalSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread)) = value;
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x060086BF RID: 34495 RVA: 0x00239F98 File Offset: 0x00238198
		// (set) Token: 0x060086C0 RID: 34496 RVA: 0x000400EF File Offset: 0x0003E2EF
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x060086C1 RID: 34497 RVA: 0x00239FC0 File Offset: 0x002381C0
		// (set) Token: 0x060086C2 RID: 34498 RVA: 0x0004010A File Offset: 0x0003E30A
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x060086C3 RID: 34499 RVA: 0x00239FF0 File Offset: 0x002381F0
		// (set) Token: 0x060086C4 RID: 34500 RVA: 0x00040129 File Offset: 0x0003E329
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x0023A020 File Offset: 0x00238220
		// (set) Token: 0x060086C6 RID: 34502 RVA: 0x00040148 File Offset: 0x0003E348
		public unsafe float timeUntilNextBlink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink)) = value;
			}
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x060086C7 RID: 34503 RVA: 0x0023A048 File Offset: 0x00238248
		// (set) Token: 0x060086C8 RID: 34504 RVA: 0x00040163 File Offset: 0x0003E363
		public unsafe bool eyeBallTintOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden)) = value;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x060086C9 RID: 34505 RVA: 0x0023A070 File Offset: 0x00238270
		// (set) Token: 0x060086CA RID: 34506 RVA: 0x0004017E File Offset: 0x0003E37E
		public unsafe bool eyeLidOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden)) = value;
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x0023A098 File Offset: 0x00238298
		// (set) Token: 0x060086CC RID: 34508 RVA: 0x00040199 File Offset: 0x0003E399
		public unsafe Eye.EyeLidConfiguration defaultLeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState)) = value;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x0023A0C0 File Offset: 0x002382C0
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x000401B4 File Offset: 0x0003E3B4
		public unsafe Eye.EyeLidConfiguration defaultRightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState)) = value;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x0023A0E8 File Offset: 0x002382E8
		// (set) Token: 0x060086D0 RID: 34512 RVA: 0x000401CF File Offset: 0x0003E3CF
		public unsafe float defaultDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation)) = value;
			}
		}

		// Token: 0x04005B8C RID: 23436
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeightMultiplier;

		// Token: 0x04005B8D RID: 23437
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005B8E RID: 23438
		private static readonly IntPtr NativeFieldInfoPtr__EyesOpen_k__BackingField;

		// Token: 0x04005B8F RID: 23439
		private static readonly IntPtr NativeFieldInfoPtr_leftEye;

		// Token: 0x04005B90 RID: 23440
		private static readonly IntPtr NativeFieldInfoPtr_rightEye;

		// Token: 0x04005B91 RID: 23441
		private static readonly IntPtr NativeFieldInfoPtr_eyeSpacing;

		// Token: 0x04005B92 RID: 23442
		private static readonly IntPtr NativeFieldInfoPtr_eyeHeight;

		// Token: 0x04005B93 RID: 23443
		private static readonly IntPtr NativeFieldInfoPtr_eyeSize;

		// Token: 0x04005B94 RID: 23444
		private static readonly IntPtr NativeFieldInfoPtr_leftEyeLidColor;

		// Token: 0x04005B95 RID: 23445
		private static readonly IntPtr NativeFieldInfoPtr_rightEyeLidColor;

		// Token: 0x04005B96 RID: 23446
		private static readonly IntPtr NativeFieldInfoPtr_LeftRestingEyeState;

		// Token: 0x04005B97 RID: 23447
		private static readonly IntPtr NativeFieldInfoPtr_RightRestingEyeState;

		// Token: 0x04005B98 RID: 23448
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallMaterial;

		// Token: 0x04005B99 RID: 23449
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallColor;

		// Token: 0x04005B9A RID: 23450
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005B9B RID: 23451
		private static readonly IntPtr NativeFieldInfoPtr_BlinkingEnabled;

		// Token: 0x04005B9C RID: 23452
		private static readonly IntPtr NativeFieldInfoPtr_blinkInterval;

		// Token: 0x04005B9D RID: 23453
		private static readonly IntPtr NativeFieldInfoPtr_blinkIntervalSpread;

		// Token: 0x04005B9E RID: 23454
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04005B9F RID: 23455
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005BA0 RID: 23456
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005BA1 RID: 23457
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilNextBlink;

		// Token: 0x04005BA2 RID: 23458
		private static readonly IntPtr NativeFieldInfoPtr_eyeBallTintOverridden;

		// Token: 0x04005BA3 RID: 23459
		private static readonly IntPtr NativeFieldInfoPtr_eyeLidOverridden;

		// Token: 0x04005BA4 RID: 23460
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftEyeRestingState;

		// Token: 0x04005BA5 RID: 23461
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightEyeRestingState;

		// Token: 0x04005BA6 RID: 23462
		private static readonly IntPtr NativeFieldInfoPtr_defaultDilation;

		// Token: 0x04005BA7 RID: 23463
		private static readonly IntPtr NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0;

		// Token: 0x04005BA8 RID: 23464
		private static readonly IntPtr NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005BA9 RID: 23465
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005BAA RID: 23466
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04005BAB RID: 23467
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005BAC RID: 23468
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_0;

		// Token: 0x04005BAD RID: 23469
		private static readonly IntPtr NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0;

		// Token: 0x04005BAE RID: 23470
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0;

		// Token: 0x04005BAF RID: 23471
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0;

		// Token: 0x04005BB0 RID: 23472
		private static readonly IntPtr NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BB1 RID: 23473
		private static readonly IntPtr NativeMethodInfoPtr_ResetEyeLids_Public_Void_0;

		// Token: 0x04005BB2 RID: 23474
		private static readonly IntPtr NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005BB3 RID: 23475
		private static readonly IntPtr NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0;

		// Token: 0x04005BB4 RID: 23476
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDilation_Private_Void_0;

		// Token: 0x04005BB5 RID: 23477
		private static readonly IntPtr NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0;

		// Token: 0x04005BB6 RID: 23478
		private static readonly IntPtr NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0;

		// Token: 0x04005BB7 RID: 23479
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0;

		// Token: 0x04005BB8 RID: 23480
		private static readonly IntPtr NativeMethodInfoPtr_ForceBlink_Public_Void_0;

		// Token: 0x04005BB9 RID: 23481
		private static readonly IntPtr NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BBA RID: 23482
		private static readonly IntPtr NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005BBB RID: 23483
		private static readonly IntPtr NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0;

		// Token: 0x04005BBC RID: 23484
		private static readonly IntPtr NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0;

		// Token: 0x04005BBD RID: 23485
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005BBE RID: 23486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BBF RID: 23487
		private static readonly IntPtr NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0;

		// Token: 0x02000AF2 RID: 2802
		[ObfuscatedName("ScheduleOne.AvatarFramework.EyeController+<BlinkRoutine>d__48")]
		public sealed class _BlinkRoutine_d__48 : Il2CppSystem.Object
		{
			// Token: 0x0600D5A7 RID: 54695 RVA: 0x0032E7D4 File Offset: 0x0032C9D4
			// Note: this type is marked as 'beforefieldinit'.
			static _BlinkRoutine_d__48()
			{
				Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<BlinkRoutine>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr);
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>1__state");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>2__current");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>4__this");
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680122);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680123);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680124);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680125);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680126);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680127);
			}

			// Token: 0x0600D5A8 RID: 54696 RVA: 0x0032E8B4 File Offset: 0x0032CAB4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BlinkRoutine_d__48(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A9 RID: 54697 RVA: 0x0032E8FC File Offset: 0x0032CAFC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5AA RID: 54698 RVA: 0x0032E930 File Offset: 0x0032CB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250752, XrefRangeEnd = 250772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004237 RID: 16951
			// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x0032E96C File Offset: 0x0032CB6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5AC RID: 54700 RVA: 0x0032E9AC File Offset: 0x0032CBAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250772, XrefRangeEnd = 250777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004238 RID: 16952
			// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x0032E9E0 File Offset: 0x0032CBE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D5AE RID: 54702 RVA: 0x00067F40 File Offset: 0x00066140
			public _BlinkRoutine_d__48(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004234 RID: 16948
			// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x0032EA20 File Offset: 0x0032CC20
			// (set) Token: 0x0600D5B0 RID: 54704 RVA: 0x00067F49 File Offset: 0x00066149
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004235 RID: 16949
			// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x0032EA48 File Offset: 0x0032CC48
			// (set) Token: 0x0600D5B2 RID: 54706 RVA: 0x00067F64 File Offset: 0x00066164
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004236 RID: 16950
			// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x0032EA78 File Offset: 0x0032CC78
			// (set) Token: 0x0600D5B4 RID: 54708 RVA: 0x00067F83 File Offset: 0x00066183
			public unsafe EyeController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FB7 RID: 36791
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FB8 RID: 36792
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FB9 RID: 36793
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FBA RID: 36794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FBB RID: 36795
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FBC RID: 36796
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FBD RID: 36797
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FBE RID: 36798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FBF RID: 36799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
