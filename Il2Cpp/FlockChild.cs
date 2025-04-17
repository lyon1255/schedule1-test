using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000037 RID: 55
	public class FlockChild : MonoBehaviour
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0007C3D4 File Offset: 0x0007A5D4
		// Note: this type is marked as 'beforefieldinit'.
		static FlockChild()
		{
			Il2CppClassPointerStore<FlockChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockChild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockChild>.NativeClassPtr);
			FlockChild.NativeFieldInfoPtr__spawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_spawner");
			FlockChild.NativeFieldInfoPtr__wayPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_wayPoint");
			FlockChild.NativeFieldInfoPtr__speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_speed");
			FlockChild.NativeFieldInfoPtr__dived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_dived");
			FlockChild.NativeFieldInfoPtr__stuckCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_stuckCounter");
			FlockChild.NativeFieldInfoPtr__damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_damping");
			FlockChild.NativeFieldInfoPtr__soar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_soar");
			FlockChild.NativeFieldInfoPtr__landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_landing");
			FlockChild.NativeFieldInfoPtr__targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_targetSpeed");
			FlockChild.NativeFieldInfoPtr__move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_move");
			FlockChild.NativeFieldInfoPtr__model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_model");
			FlockChild.NativeFieldInfoPtr__modelT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_modelT");
			FlockChild.NativeFieldInfoPtr__avoidValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoidValue");
			FlockChild.NativeFieldInfoPtr__avoidDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoidDistance");
			FlockChild.NativeFieldInfoPtr__soarTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_soarTimer");
			FlockChild.NativeFieldInfoPtr__instantiated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_instantiated");
			FlockChild.NativeFieldInfoPtr__updateNextSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_updateNextSeed");
			FlockChild.NativeFieldInfoPtr__updateSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_updateSeed");
			FlockChild.NativeFieldInfoPtr__avoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_avoid");
			FlockChild.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_thisT");
			FlockChild.NativeFieldInfoPtr__landingPosOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, "_landingPosOffset");
			FlockChild.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663655);
			FlockChild.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663656);
			FlockChild.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663657);
			FlockChild.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663658);
			FlockChild.NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663659);
			FlockChild.NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663660);
			FlockChild.NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663661);
			FlockChild.NativeMethodInfoPtr_SetRandomScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663662);
			FlockChild.NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663663);
			FlockChild.NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663664);
			FlockChild.NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663665);
			FlockChild.NativeMethodInfoPtr_Avoidance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663666);
			FlockChild.NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663667);
			FlockChild.NativeMethodInfoPtr_Wander_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663668);
			FlockChild.NativeMethodInfoPtr_SetRandomMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663669);
			FlockChild.NativeMethodInfoPtr_Flap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663670);
			FlockChild.NativeMethodInfoPtr_findWaypoint_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663671);
			FlockChild.NativeMethodInfoPtr_Soar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663672);
			FlockChild.NativeMethodInfoPtr_Dive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663673);
			FlockChild.NativeMethodInfoPtr_animationSpeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663674);
			FlockChild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockChild>.NativeClassPtr, 100663675);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0007C74C File Offset: 0x0007A94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73823, XrefRangeEnd = 73855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0007C780 File Offset: 0x0007A980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73855, XrefRangeEnd = 73863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0007C7B4 File Offset: 0x0007A9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73863, XrefRangeEnd = 73864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0007C7E8 File Offset: 0x0007A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73864, XrefRangeEnd = 73868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0007C81C File Offset: 0x0007AA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73868, XrefRangeEnd = 73887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindRequiredComponents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0007C850 File Offset: 0x0007AA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73910, RefRangeEnd = 73911, XrefRangeStart = 73887, XrefRangeEnd = 73910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeStartAnimationFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0007C884 File Offset: 0x0007AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73911, XrefRangeEnd = 73912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitAvoidanceValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0007C8B8 File Offset: 0x0007AAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73912, XrefRangeEnd = 73914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SetRandomScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0007C8EC File Offset: 0x0007AAEC
		[CallerCount(0)]
		public unsafe void SoarTimeLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0007C920 File Offset: 0x0007AB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73914, XrefRangeEnd = 73917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForDistanceToWaypoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0007C954 File Offset: 0x0007AB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73932, RefRangeEnd = 73933, XrefRangeStart = 73917, XrefRangeEnd = 73932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotationBasedOnWaypointOrAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0007C988 File Offset: 0x0007AB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73978, RefRangeEnd = 73979, XrefRangeStart = 73933, XrefRangeEnd = 73978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Avoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Avoidance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0007C9C4 File Offset: 0x0007ABC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73997, RefRangeEnd = 73998, XrefRangeStart = 73979, XrefRangeEnd = 73997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LimitRotationOfModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74003, RefRangeEnd = 74008, XrefRangeStart = 73998, XrefRangeEnd = 74003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wander(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Wander_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0007CA38 File Offset: 0x0007AC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74008, XrefRangeEnd = 74017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_SetRandomMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0007CA6C File Offset: 0x0007AC6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74027, RefRangeEnd = 74029, XrefRangeStart = 74017, XrefRangeEnd = 74027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Flap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0007CAA0 File Offset: 0x0007ACA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74034, RefRangeEnd = 74039, XrefRangeStart = 74029, XrefRangeEnd = 74034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 findWaypoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_findWaypoint_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0007CADC File Offset: 0x0007ACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74039, XrefRangeEnd = 74044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Soar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Soar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0007CB10 File Offset: 0x0007AD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74044, XrefRangeEnd = 74071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_Dive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0007CB44 File Offset: 0x0007AD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74095, RefRangeEnd = 74096, XrefRangeStart = 74071, XrefRangeEnd = 74095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void animationSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr_animationSpeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0007CB78 File Offset: 0x0007AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74096, XrefRangeEnd = 74097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockChild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockChild>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockChild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000441C File Offset: 0x0000261C
		public FlockChild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00004425 File Offset: 0x00002625
		public unsafe FlockController _spawner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__spawner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__spawner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0007CBE4 File Offset: 0x0007ADE4
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00004444 File Offset: 0x00002644
		public unsafe Vector3 _wayPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__wayPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__wayPoint)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0007CC0C File Offset: 0x0007AE0C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000445F File Offset: 0x0000265F
		public unsafe float _speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__speed)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0007CC34 File Offset: 0x0007AE34
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000447A File Offset: 0x0000267A
		public unsafe bool _dived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__dived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__dived)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0007CC5C File Offset: 0x0007AE5C
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00004495 File Offset: 0x00002695
		public unsafe float _stuckCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__stuckCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__stuckCounter)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0007CC84 File Offset: 0x0007AE84
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x000044B0 File Offset: 0x000026B0
		public unsafe float _damping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__damping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__damping)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0007CCAC File Offset: 0x0007AEAC
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000044CB File Offset: 0x000026CB
		public unsafe bool _soar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soar)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0007CCD4 File Offset: 0x0007AED4
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000044E6 File Offset: 0x000026E6
		public unsafe bool _landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landing)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0007CCFC File Offset: 0x0007AEFC
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00004501 File Offset: 0x00002701
		public unsafe float _targetSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__targetSpeed)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0007CD24 File Offset: 0x0007AF24
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000451C File Offset: 0x0000271C
		public unsafe bool _move
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__move);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__move)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0007CD4C File Offset: 0x0007AF4C
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00004537 File Offset: 0x00002737
		public unsafe GameObject _model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0007CD7C File Offset: 0x0007AF7C
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00004556 File Offset: 0x00002756
		public unsafe Transform _modelT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__modelT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__modelT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00004575 File Offset: 0x00002775
		public unsafe float _avoidValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidValue)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0007CDD4 File Offset: 0x0007AFD4
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00004590 File Offset: 0x00002790
		public unsafe float _avoidDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoidDistance)) = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0007CDFC File Offset: 0x0007AFFC
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x000045AB File Offset: 0x000027AB
		public unsafe float _soarTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soarTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__soarTimer)) = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0007CE24 File Offset: 0x0007B024
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000045C6 File Offset: 0x000027C6
		public unsafe bool _instantiated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__instantiated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__instantiated)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0007CE4C File Offset: 0x0007B04C
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000045E1 File Offset: 0x000027E1
		public unsafe static int _updateNextSeed
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FlockChild.NativeFieldInfoPtr__updateNextSeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlockChild.NativeFieldInfoPtr__updateNextSeed, (void*)(&value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0007CE68 File Offset: 0x0007B068
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000045EF File Offset: 0x000027EF
		public unsafe int _updateSeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__updateSeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__updateSeed)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0007CE90 File Offset: 0x0007B090
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0000460A File Offset: 0x0000280A
		public unsafe bool _avoid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__avoid)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0007CEB8 File Offset: 0x0007B0B8
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00004625 File Offset: 0x00002825
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0007CEE8 File Offset: 0x0007B0E8
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00004644 File Offset: 0x00002844
		public unsafe Vector3 _landingPosOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landingPosOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockChild.NativeFieldInfoPtr__landingPosOffset)) = value;
			}
		}

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr__spawner;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr__wayPoint;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr__speed;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr__dived;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr__stuckCounter;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr__damping;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr__soar;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr__landing;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr__targetSpeed;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr__move;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr__model;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr__modelT;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr__avoidValue;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr__avoidDistance;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr__soarTimer;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr__instantiated;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr__updateNextSeed;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr__updateSeed;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr__avoid;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr__landingPosOffset;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_FindRequiredComponents_Public_Void_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeStartAnimationFrame_Public_Void_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_InitAvoidanceValues_Public_Void_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomScale_Public_Void_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_SoarTimeLimit_Public_Void_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_CheckForDistanceToWaypoint_Public_Void_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_RotationBasedOnWaypointOrAvoidance_Public_Void_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_Avoidance_Public_Boolean_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_LimitRotationOfModel_Public_Void_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_Wander_Public_Void_Single_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomMode_Public_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_Flap_Public_Void_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_findWaypoint_Public_Vector3_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_Soar_Public_Void_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_Dive_Public_Void_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_animationSpeed_Public_Void_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
