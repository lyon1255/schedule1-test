using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004F3 RID: 1267
	public class Wheel : MonoBehaviour
	{
		// Token: 0x06006FDD RID: 28637 RVA: 0x001ED008 File Offset: 0x001EB208
		// Note: this type is marked as 'beforefieldinit'.
		static Wheel()
		{
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Wheel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
			Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SIDEWAY_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "FORWARD_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DRIFT_AUDIO_THRESHOLD");
			Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "MIN_SPEED_FOR_DRIFT");
			Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "WHEEL_ANIMATION_DISTANCE");
			Wheel.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DEBUG_MODE");
			Wheel.NativeFieldInfoPtr_wheelModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelModel");
			Wheel.NativeFieldInfoPtr_modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "modelContainer");
			Wheel.NativeFieldInfoPtr_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelCollider");
			Wheel.NativeFieldInfoPtr_axleConnectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "axleConnectionPoint");
			Wheel.NativeFieldInfoPtr_staticCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "staticCollider");
			Wheel.NativeFieldInfoPtr_DriftParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticles");
			Wheel.NativeFieldInfoPtr_DriftParticlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticlesEnabled");
			Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "ForwardStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SidewayStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_DriftAudioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioEnabled");
			Wheel.NativeFieldInfoPtr_DriftAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioSource");
			Wheel.NativeFieldInfoPtr_defaultForwardStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultForwardStiffness");
			Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultSidewaysStiffness");
			Wheel.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<isStatic>k__BackingField");
			Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<IsDrifting>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftTime>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftIntensity>k__BackingField");
			Wheel.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "vehicle");
			Wheel.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "lastFramePosition");
			Wheel.NativeFieldInfoPtr_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelData");
			Wheel.NativeFieldInfoPtr_forwardCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "forwardCurve");
			Wheel.NativeFieldInfoPtr_sidewaysCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "sidewaysCurve");
			Wheel.NativeFieldInfoPtr_wheelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelTransform");
			Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677398);
			Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677399);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677400);
			Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677401);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677402);
			Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677403);
			Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677404);
			Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677405);
			Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677406);
			Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677407);
			Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677408);
			Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677409);
			Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677410);
			Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677411);
			Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677412);
			Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677413);
			Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677414);
			Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677415);
			Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677416);
			Wheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677417);
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x001ED40C File Offset: 0x001EB60C
		// (set) Token: 0x06006FDF RID: 28639 RVA: 0x001ED448 File Offset: 0x001EB648
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x001ED488 File Offset: 0x001EB688
		// (set) Token: 0x06006FE1 RID: 28641 RVA: 0x001ED4C4 File Offset: 0x001EB6C4
		public unsafe bool IsDrifting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06006FE2 RID: 28642 RVA: 0x001ED504 File Offset: 0x001EB704
		public unsafe bool IsDrifting_Smoothed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06006FE3 RID: 28643 RVA: 0x001ED540 File Offset: 0x001EB740
		// (set) Token: 0x06006FE4 RID: 28644 RVA: 0x001ED57C File Offset: 0x001EB77C
		public unsafe float DriftTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06006FE5 RID: 28645 RVA: 0x001ED5BC File Offset: 0x001EB7BC
		// (set) Token: 0x06006FE6 RID: 28646 RVA: 0x001ED5F8 File Offset: 0x001EB7F8
		public unsafe float DriftIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x001ED638 File Offset: 0x001EB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221231, XrefRangeEnd = 221242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x001ED674 File Offset: 0x001EB874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221242, XrefRangeEnd = 221243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x001ED6B0 File Offset: 0x001EB8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221243, XrefRangeEnd = 221286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x001ED6E4 File Offset: 0x001EB8E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221317, RefRangeEnd = 221318, XrefRangeStart = 221286, XrefRangeEnd = 221317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDrifting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x001ED718 File Offset: 0x001EB918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221318, XrefRangeEnd = 221320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x001ED74C File Offset: 0x001EB94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221320, XrefRangeEnd = 221324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x001ED780 File Offset: 0x001EB980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221324, XrefRangeEnd = 221331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x001ED7B4 File Offset: 0x001EB9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221331, XrefRangeEnd = 221333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x001ED800 File Offset: 0x001EBA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221333, XrefRangeEnd = 221336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroundWheelModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x001ED834 File Offset: 0x001EBA34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221337, RefRangeEnd = 221338, XrefRangeStart = 221336, XrefRangeEnd = 221337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWheelGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x001ED870 File Offset: 0x001EBA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221338, XrefRangeEnd = 221341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wheel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00034FF6 File Offset: 0x000331F6
		public Wheel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x001ED8AC File Offset: 0x001EBAAC
		// (set) Token: 0x06006FF4 RID: 28660 RVA: 0x00034FFF File Offset: 0x000331FF
		public unsafe static float SIDEWAY_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x001ED8C8 File Offset: 0x001EBAC8
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x0003500D File Offset: 0x0003320D
		public unsafe static float FORWARD_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x001ED8E4 File Offset: 0x001EBAE4
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x0003501B File Offset: 0x0003321B
		public unsafe static float DRIFT_AUDIO_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x001ED900 File Offset: 0x001EBB00
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x00035029 File Offset: 0x00033229
		public unsafe static float MIN_SPEED_FOR_DRIFT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&value));
			}
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x001ED91C File Offset: 0x001EBB1C
		// (set) Token: 0x06006FFC RID: 28668 RVA: 0x00035037 File Offset: 0x00033237
		public unsafe static float WHEEL_ANIMATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x001ED938 File Offset: 0x001EBB38
		// (set) Token: 0x06006FFE RID: 28670 RVA: 0x00035045 File Offset: 0x00033245
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x001ED960 File Offset: 0x001EBB60
		// (set) Token: 0x06007000 RID: 28672 RVA: 0x00035060 File Offset: 0x00033260
		public unsafe Transform wheelModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x001ED990 File Offset: 0x001EBB90
		// (set) Token: 0x06007002 RID: 28674 RVA: 0x0003507F File Offset: 0x0003327F
		public unsafe Transform modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x001ED9C0 File Offset: 0x001EBBC0
		// (set) Token: 0x06007004 RID: 28676 RVA: 0x0003509E File Offset: 0x0003329E
		public unsafe WheelCollider wheelCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06007005 RID: 28677 RVA: 0x001ED9F0 File Offset: 0x001EBBF0
		// (set) Token: 0x06007006 RID: 28678 RVA: 0x000350BD File Offset: 0x000332BD
		public unsafe Transform axleConnectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06007007 RID: 28679 RVA: 0x001EDA20 File Offset: 0x001EBC20
		// (set) Token: 0x06007008 RID: 28680 RVA: 0x000350DC File Offset: 0x000332DC
		public unsafe Collider staticCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x06007009 RID: 28681 RVA: 0x001EDA50 File Offset: 0x001EBC50
		// (set) Token: 0x0600700A RID: 28682 RVA: 0x000350FB File Offset: 0x000332FB
		public unsafe ParticleSystem DriftParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x0600700B RID: 28683 RVA: 0x001EDA80 File Offset: 0x001EBC80
		// (set) Token: 0x0600700C RID: 28684 RVA: 0x0003511A File Offset: 0x0003331A
		public unsafe bool DriftParticlesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled)) = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600700D RID: 28685 RVA: 0x001EDAA8 File Offset: 0x001EBCA8
		// (set) Token: 0x0600700E RID: 28686 RVA: 0x00035135 File Offset: 0x00033335
		public unsafe float ForwardStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x001EDAD0 File Offset: 0x001EBCD0
		// (set) Token: 0x06007010 RID: 28688 RVA: 0x00035150 File Offset: 0x00033350
		public unsafe float SidewayStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x001EDAF8 File Offset: 0x001EBCF8
		// (set) Token: 0x06007012 RID: 28690 RVA: 0x0003516B File Offset: 0x0003336B
		public unsafe bool DriftAudioEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled)) = value;
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x001EDB20 File Offset: 0x001EBD20
		// (set) Token: 0x06007014 RID: 28692 RVA: 0x00035186 File Offset: 0x00033386
		public unsafe AudioSourceController DriftAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x001EDB50 File Offset: 0x001EBD50
		// (set) Token: 0x06007016 RID: 28694 RVA: 0x000351A5 File Offset: 0x000333A5
		public unsafe float defaultForwardStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness)) = value;
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x001EDB78 File Offset: 0x001EBD78
		// (set) Token: 0x06007018 RID: 28696 RVA: 0x000351C0 File Offset: 0x000333C0
		public unsafe float defaultSidewaysStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness)) = value;
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x001EDBA0 File Offset: 0x001EBDA0
		// (set) Token: 0x0600701A RID: 28698 RVA: 0x000351DB File Offset: 0x000333DB
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x001EDBC8 File Offset: 0x001EBDC8
		// (set) Token: 0x0600701C RID: 28700 RVA: 0x000351F6 File Offset: 0x000333F6
		public unsafe bool _IsDrifting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x0600701D RID: 28701 RVA: 0x001EDBF0 File Offset: 0x001EBDF0
		// (set) Token: 0x0600701E RID: 28702 RVA: 0x00035211 File Offset: 0x00033411
		public unsafe float _DriftTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600701F RID: 28703 RVA: 0x001EDC18 File Offset: 0x001EBE18
		// (set) Token: 0x06007020 RID: 28704 RVA: 0x0003522C File Offset: 0x0003342C
		public unsafe float _DriftIntensity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField)) = value;
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06007021 RID: 28705 RVA: 0x001EDC40 File Offset: 0x001EBE40
		// (set) Token: 0x06007022 RID: 28706 RVA: 0x00035247 File Offset: 0x00033447
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06007023 RID: 28707 RVA: 0x001EDC70 File Offset: 0x001EBE70
		// (set) Token: 0x06007024 RID: 28708 RVA: 0x00035266 File Offset: 0x00033466
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06007025 RID: 28709 RVA: 0x001EDC98 File Offset: 0x001EBE98
		// (set) Token: 0x06007026 RID: 28710 RVA: 0x00035281 File Offset: 0x00033481
		public WheelHit wheelData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData);
				return new WheelHit(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x001EDCC8 File Offset: 0x001EBEC8
		// (set) Token: 0x06007028 RID: 28712 RVA: 0x000352AF File Offset: 0x000334AF
		public unsafe WheelFrictionCurve forwardCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve)) = value;
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x001EDCF0 File Offset: 0x001EBEF0
		// (set) Token: 0x0600702A RID: 28714 RVA: 0x000352CA File Offset: 0x000334CA
		public unsafe WheelFrictionCurve sidewaysCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve)) = value;
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x001EDD18 File Offset: 0x001EBF18
		// (set) Token: 0x0600702C RID: 28716 RVA: 0x000352E5 File Offset: 0x000334E5
		public unsafe Transform wheelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C75 RID: 19573
		private static readonly IntPtr NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD;

		// Token: 0x04004C76 RID: 19574
		private static readonly IntPtr NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD;

		// Token: 0x04004C77 RID: 19575
		private static readonly IntPtr NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD;

		// Token: 0x04004C78 RID: 19576
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT;

		// Token: 0x04004C79 RID: 19577
		private static readonly IntPtr NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE;

		// Token: 0x04004C7A RID: 19578
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004C7B RID: 19579
		private static readonly IntPtr NativeFieldInfoPtr_wheelModel;

		// Token: 0x04004C7C RID: 19580
		private static readonly IntPtr NativeFieldInfoPtr_modelContainer;

		// Token: 0x04004C7D RID: 19581
		private static readonly IntPtr NativeFieldInfoPtr_wheelCollider;

		// Token: 0x04004C7E RID: 19582
		private static readonly IntPtr NativeFieldInfoPtr_axleConnectionPoint;

		// Token: 0x04004C7F RID: 19583
		private static readonly IntPtr NativeFieldInfoPtr_staticCollider;

		// Token: 0x04004C80 RID: 19584
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticles;

		// Token: 0x04004C81 RID: 19585
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticlesEnabled;

		// Token: 0x04004C82 RID: 19586
		private static readonly IntPtr NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake;

		// Token: 0x04004C83 RID: 19587
		private static readonly IntPtr NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake;

		// Token: 0x04004C84 RID: 19588
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioEnabled;

		// Token: 0x04004C85 RID: 19589
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioSource;

		// Token: 0x04004C86 RID: 19590
		private static readonly IntPtr NativeFieldInfoPtr_defaultForwardStiffness;

		// Token: 0x04004C87 RID: 19591
		private static readonly IntPtr NativeFieldInfoPtr_defaultSidewaysStiffness;

		// Token: 0x04004C88 RID: 19592
		private static readonly IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004C89 RID: 19593
		private static readonly IntPtr NativeFieldInfoPtr__IsDrifting_k__BackingField;

		// Token: 0x04004C8A RID: 19594
		private static readonly IntPtr NativeFieldInfoPtr__DriftTime_k__BackingField;

		// Token: 0x04004C8B RID: 19595
		private static readonly IntPtr NativeFieldInfoPtr__DriftIntensity_k__BackingField;

		// Token: 0x04004C8C RID: 19596
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004C8D RID: 19597
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004C8E RID: 19598
		private static readonly IntPtr NativeFieldInfoPtr_wheelData;

		// Token: 0x04004C8F RID: 19599
		private static readonly IntPtr NativeFieldInfoPtr_forwardCurve;

		// Token: 0x04004C90 RID: 19600
		private static readonly IntPtr NativeFieldInfoPtr_sidewaysCurve;

		// Token: 0x04004C91 RID: 19601
		private static readonly IntPtr NativeFieldInfoPtr_wheelTransform;

		// Token: 0x04004C92 RID: 19602
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004C93 RID: 19603
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004C94 RID: 19604
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0;

		// Token: 0x04004C95 RID: 19605
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0;

		// Token: 0x04004C96 RID: 19606
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0;

		// Token: 0x04004C97 RID: 19607
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0;

		// Token: 0x04004C98 RID: 19608
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0;

		// Token: 0x04004C99 RID: 19609
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0;

		// Token: 0x04004C9A RID: 19610
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0;

		// Token: 0x04004C9B RID: 19611
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004C9C RID: 19612
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004C9D RID: 19613
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004C9E RID: 19614
		private static readonly IntPtr NativeMethodInfoPtr_CheckDrifting_Private_Void_0;

		// Token: 0x04004C9F RID: 19615
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0;

		// Token: 0x04004CA0 RID: 19616
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0;

		// Token: 0x04004CA1 RID: 19617
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFriction_Private_Void_0;

		// Token: 0x04004CA2 RID: 19618
		private static readonly IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004CA3 RID: 19619
		private static readonly IntPtr NativeMethodInfoPtr_GroundWheelModel_Private_Void_0;

		// Token: 0x04004CA4 RID: 19620
		private static readonly IntPtr NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0;

		// Token: 0x04004CA5 RID: 19621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
