using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003E RID: 62
	public class LandingSpotController : MonoBehaviour
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0007EF2C File Offset: 0x0007D12C
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpotController()
		{
			Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpotController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr);
			LandingSpotController.NativeFieldInfoPtr__randomRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_randomRotate");
			LandingSpotController.NativeFieldInfoPtr__autoCatchDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoCatchDelay");
			LandingSpotController.NativeFieldInfoPtr__autoDismountDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_autoDismountDelay");
			LandingSpotController.NativeFieldInfoPtr__maxBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_maxBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__minBirdDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_minBirdDistance");
			LandingSpotController.NativeFieldInfoPtr__takeClosest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_takeClosest");
			LandingSpotController.NativeFieldInfoPtr__flock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_flock");
			LandingSpotController.NativeFieldInfoPtr__landOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landOnStart");
			LandingSpotController.NativeFieldInfoPtr__soarLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_soarLand");
			LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_onlyBirdsAbove");
			LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landingTurnSpeedModifier");
			LandingSpotController.NativeFieldInfoPtr__featherPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_featherPS");
			LandingSpotController.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_thisT");
			LandingSpotController.NativeFieldInfoPtr__activeLandingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_activeLandingSpots");
			LandingSpotController.NativeFieldInfoPtr__snapLandDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_snapLandDistance");
			LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_landedRotateSpeed");
			LandingSpotController.NativeFieldInfoPtr__gizmoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "_gizmoSize");
			LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663718);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663719);
			LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663720);
			LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663721);
			LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663722);
			LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663723);
			LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, 100663724);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0007F150 File Offset: 0x0007D350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74683, XrefRangeEnd = 74719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0007F184 File Offset: 0x0007D384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74736, RefRangeEnd = 74738, XrefRangeStart = 74719, XrefRangeEnd = 74736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0007F1B8 File Offset: 0x0007D3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74738, XrefRangeEnd = 74755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScareAll(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0007F204 File Offset: 0x0007D404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74755, XrefRangeEnd = 74770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LandAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_LandAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0007F238 File Offset: 0x0007D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74770, XrefRangeEnd = 74775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLandOnStart(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0007F284 File Offset: 0x0007D484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74775, XrefRangeEnd = 74780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantLand(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0007F2D0 File Offset: 0x0007D4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74780, XrefRangeEnd = 74781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpotController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00004FC9 File Offset: 0x000031C9
		public LandingSpotController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0007F30C File Offset: 0x0007D50C
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004FD2 File Offset: 0x000031D2
		public unsafe bool _randomRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__randomRotate)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0007F334 File Offset: 0x0007D534
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004FED File Offset: 0x000031ED
		public unsafe Vector2 _autoCatchDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoCatchDelay)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0007F35C File Offset: 0x0007D55C
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00005008 File Offset: 0x00003208
		public unsafe Vector2 _autoDismountDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__autoDismountDelay)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0007F384 File Offset: 0x0007D584
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00005023 File Offset: 0x00003223
		public unsafe float _maxBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__maxBirdDistance)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0007F3AC File Offset: 0x0007D5AC
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x0000503E File Offset: 0x0000323E
		public unsafe float _minBirdDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__minBirdDistance)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0007F3D4 File Offset: 0x0007D5D4
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00005059 File Offset: 0x00003259
		public unsafe bool _takeClosest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__takeClosest)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0007F3FC File Offset: 0x0007D5FC
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00005074 File Offset: 0x00003274
		public unsafe FlockController _flock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__flock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0007F42C File Offset: 0x0007D62C
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00005093 File Offset: 0x00003293
		public unsafe bool _landOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landOnStart)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0007F454 File Offset: 0x0007D654
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000050AE File Offset: 0x000032AE
		public unsafe bool _soarLand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__soarLand)) = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0007F47C File Offset: 0x0007D67C
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x000050C9 File Offset: 0x000032C9
		public unsafe bool _onlyBirdsAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__onlyBirdsAbove)) = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x000050E4 File Offset: 0x000032E4
		public unsafe float _landingSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingSpeedModifier)) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0007F4CC File Offset: 0x0007D6CC
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x000050FF File Offset: 0x000032FF
		public unsafe float _landingTurnSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landingTurnSpeedModifier)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0007F4F4 File Offset: 0x0007D6F4
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000511A File Offset: 0x0000331A
		public unsafe Transform _featherPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__featherPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0007F524 File Offset: 0x0007D724
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00005139 File Offset: 0x00003339
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0007F554 File Offset: 0x0007D754
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00005158 File Offset: 0x00003358
		public unsafe int _activeLandingSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__activeLandingSpots)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0007F57C File Offset: 0x0007D77C
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00005173 File Offset: 0x00003373
		public unsafe float _snapLandDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__snapLandDistance)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0000518E File Offset: 0x0000338E
		public unsafe float _landedRotateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__landedRotateSpeed)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x000051A9 File Offset: 0x000033A9
		public unsafe float _gizmoSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController.NativeFieldInfoPtr__gizmoSize)) = value;
			}
		}

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr__randomRotate;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr__autoCatchDelay;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr__autoDismountDelay;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr__maxBirdDistance;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr__minBirdDistance;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr__takeClosest;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr__flock;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr__landOnStart;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr__soarLand;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr__onlyBirdsAbove;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr__landingSpeedModifier;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr__landingTurnSpeedModifier;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr__featherPS;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr__activeLandingSpots;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr__snapLandDistance;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr__landedRotateSpeed;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr__gizmoSize;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_ScareAll_Public_Void_Single_Single_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_LandAll_Public_Void_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_InstantLandOnStart_Public_IEnumerator_Single_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_IEnumerator_Single_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B4 RID: 1972
		[ObfuscatedName("LandingSpotController+<InstantLand>d__23")]
		public sealed class _InstantLand_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600B9CD RID: 47565 RVA: 0x002E1A20 File Offset: 0x002DFC20
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLand_d__23()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLand>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr);
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "delay");
				LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663725);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663726);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663727);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663728);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663729);
				LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr, 100663730);
			}

			// Token: 0x0600B9CE RID: 47566 RVA: 0x002E1B14 File Offset: 0x002DFD14
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLand_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLand_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9CF RID: 47567 RVA: 0x002E1B5C File Offset: 0x002DFD5C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9D0 RID: 47568 RVA: 0x002E1B90 File Offset: 0x002DFD90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74659, XrefRangeEnd = 74666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003959 RID: 14681
			// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x002E1BCC File Offset: 0x002DFDCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9D2 RID: 47570 RVA: 0x002E1C0C File Offset: 0x002DFE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74666, XrefRangeEnd = 74671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700395A RID: 14682
			// (get) Token: 0x0600B9D3 RID: 47571 RVA: 0x002E1C40 File Offset: 0x002DFE40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLand_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9D4 RID: 47572 RVA: 0x0005AD6A File Offset: 0x00058F6A
			public _InstantLand_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003955 RID: 14677
			// (get) Token: 0x0600B9D5 RID: 47573 RVA: 0x002E1C80 File Offset: 0x002DFE80
			// (set) Token: 0x0600B9D6 RID: 47574 RVA: 0x0005AD73 File Offset: 0x00058F73
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003956 RID: 14678
			// (get) Token: 0x0600B9D7 RID: 47575 RVA: 0x002E1CA8 File Offset: 0x002DFEA8
			// (set) Token: 0x0600B9D8 RID: 47576 RVA: 0x0005AD8E File Offset: 0x00058F8E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003957 RID: 14679
			// (get) Token: 0x0600B9D9 RID: 47577 RVA: 0x002E1CD8 File Offset: 0x002DFED8
			// (set) Token: 0x0600B9DA RID: 47578 RVA: 0x0005ADAD File Offset: 0x00058FAD
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17003958 RID: 14680
			// (get) Token: 0x0600B9DB RID: 47579 RVA: 0x002E1D00 File Offset: 0x002DFF00
			// (set) Token: 0x0600B9DC RID: 47580 RVA: 0x0005ADC8 File Offset: 0x00058FC8
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLand_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D51 RID: 32081
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D52 RID: 32082
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D53 RID: 32083
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04007D54 RID: 32084
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D55 RID: 32085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D56 RID: 32086
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D57 RID: 32087
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D58 RID: 32088
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D59 RID: 32089
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D5A RID: 32090
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007B5 RID: 1973
		[ObfuscatedName("LandingSpotController+<InstantLandOnStart>d__22")]
		public sealed class _InstantLandOnStart_d__22 : Il2CppSystem.Object
		{
			// Token: 0x0600B9DD RID: 47581 RVA: 0x002E1D30 File Offset: 0x002DFF30
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantLandOnStart_d__22()
			{
				Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpotController>.NativeClassPtr, "<InstantLandOnStart>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr);
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>1__state");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>2__current");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "delay");
				LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, "<>4__this");
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663731);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663732);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663733);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663734);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663735);
				LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr, 100663736);
			}

			// Token: 0x0600B9DE RID: 47582 RVA: 0x002E1E24 File Offset: 0x002E0024
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantLandOnStart_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpotController._InstantLandOnStart_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9DF RID: 47583 RVA: 0x002E1E6C File Offset: 0x002E006C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9E0 RID: 47584 RVA: 0x002E1EA0 File Offset: 0x002E00A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74671, XrefRangeEnd = 74678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700395F RID: 14687
			// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002E1EDC File Offset: 0x002E00DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9E2 RID: 47586 RVA: 0x002E1F1C File Offset: 0x002E011C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74678, XrefRangeEnd = 74683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003960 RID: 14688
			// (get) Token: 0x0600B9E3 RID: 47587 RVA: 0x002E1F50 File Offset: 0x002E0150
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpotController._InstantLandOnStart_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9E4 RID: 47588 RVA: 0x0005ADE7 File Offset: 0x00058FE7
			public _InstantLandOnStart_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700395B RID: 14683
			// (get) Token: 0x0600B9E5 RID: 47589 RVA: 0x002E1F90 File Offset: 0x002E0190
			// (set) Token: 0x0600B9E6 RID: 47590 RVA: 0x0005ADF0 File Offset: 0x00058FF0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700395C RID: 14684
			// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x002E1FB8 File Offset: 0x002E01B8
			// (set) Token: 0x0600B9E8 RID: 47592 RVA: 0x0005AE0B File Offset: 0x0005900B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700395D RID: 14685
			// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002E1FE8 File Offset: 0x002E01E8
			// (set) Token: 0x0600B9EA RID: 47594 RVA: 0x0005AE2A File Offset: 0x0005902A
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700395E RID: 14686
			// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x002E2010 File Offset: 0x002E0210
			// (set) Token: 0x0600B9EC RID: 47596 RVA: 0x0005AE45 File Offset: 0x00059045
			public unsafe LandingSpotController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpotController._InstantLandOnStart_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D5B RID: 32091
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D5C RID: 32092
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D5D RID: 32093
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04007D5E RID: 32094
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D5F RID: 32095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D60 RID: 32096
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D61 RID: 32097
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D62 RID: 32098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D63 RID: 32099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D64 RID: 32100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
