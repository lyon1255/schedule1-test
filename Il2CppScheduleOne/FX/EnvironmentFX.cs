using System;
using Il2CppAtmosphericHeightFog;
using Il2CppFunly.SkyStudio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppVolumetricFogAndMist2;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003F6 RID: 1014
	public class EnvironmentFX : Singleton<EnvironmentFX>
	{
		// Token: 0x0600543D RID: 21565 RVA: 0x0018B668 File Offset: 0x00189868
		// Note: this type is marked as 'beforefieldinit'.
		static EnvironmentFX()
		{
			Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "EnvironmentFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr);
			EnvironmentFX.NativeFieldInfoPtr_windZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "windZone");
			EnvironmentFX.NativeFieldInfoPtr_timeOfDayController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "timeOfDayController");
			EnvironmentFX.NativeFieldInfoPtr_HeightFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFog");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFog");
			EnvironmentFX.NativeFieldInfoPtr_SunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "SunLight");
			EnvironmentFX.NativeFieldInfoPtr_MoonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "MoonLight");
			EnvironmentFX.NativeFieldInfoPtr_fogColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceCurve");
			EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "fogEndDistanceMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogColor");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "HeightFogDirectionalIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogColor");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "VolumetricFogIntensityMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "godRayIntensityCurve");
			EnvironmentFX.NativeFieldInfoPtr_contrastCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contrastCurve");
			EnvironmentFX.NativeFieldInfoPtr_contractMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "contractMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_saturationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationCurve");
			EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "saturationMultiplier");
			EnvironmentFX.NativeFieldInfoPtr_grassMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassMat");
			EnvironmentFX.NativeFieldInfoPtr_grassColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "grassColorGradient");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeMat");
			EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "distanceTreeColorCurve");
			EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "environmentalBrightnessCurve");
			EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "bloomThreshholdCurve");
			EnvironmentFX.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "started");
			EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, "FogEndDistanceController");
			EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673803);
			EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673804);
			EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673805);
			EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673806);
			EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673807);
			EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr, 100673808);
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x0018B954 File Offset: 0x00189B54
		public unsafe float normalizedEnvironmentalBrightness
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 179821, RefRangeEnd = 179824, XrefRangeStart = 179812, XrefRangeEnd = 179821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x0018B990 File Offset: 0x00189B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179824, XrefRangeEnd = 179842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x0018B9CC File Offset: 0x00189BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179842, XrefRangeEnd = 179852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x0018BA00 File Offset: 0x00189C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179898, RefRangeEnd = 179899, XrefRangeStart = 179852, XrefRangeEnd = 179898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x0018BA34 File Offset: 0x00189C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179899, XrefRangeEnd = 179902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnvironmentFX.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x0018BA70 File Offset: 0x00189C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179902, XrefRangeEnd = 179905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvironmentFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentFX>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvironmentFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x000284AC File Offset: 0x000266AC
		public EnvironmentFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x0018BAAC File Offset: 0x00189CAC
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x000284B5 File Offset: 0x000266B5
		public unsafe WindZone windZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_windZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x0018BADC File Offset: 0x00189CDC
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x000284D4 File Offset: 0x000266D4
		public unsafe TimeOfDayController timeOfDayController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeOfDayController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_timeOfDayController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06005449 RID: 21577 RVA: 0x0018BB0C File Offset: 0x00189D0C
		// (set) Token: 0x0600544A RID: 21578 RVA: 0x000284F3 File Offset: 0x000266F3
		public unsafe HeightFogGlobal HeightFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeightFogGlobal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x0600544B RID: 21579 RVA: 0x0018BB3C File Offset: 0x00189D3C
		// (set) Token: 0x0600544C RID: 21580 RVA: 0x00028512 File Offset: 0x00026712
		public unsafe VolumetricFog VolumetricFog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricFog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x0018BB6C File Offset: 0x00189D6C
		// (set) Token: 0x0600544E RID: 21582 RVA: 0x00028531 File Offset: 0x00026731
		public unsafe Light SunLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_SunLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600544F RID: 21583 RVA: 0x0018BB9C File Offset: 0x00189D9C
		// (set) Token: 0x06005450 RID: 21584 RVA: 0x00028550 File Offset: 0x00026750
		public unsafe Light MoonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_MoonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06005451 RID: 21585 RVA: 0x0018BBCC File Offset: 0x00189DCC
		// (set) Token: 0x06005452 RID: 21586 RVA: 0x0002856F File Offset: 0x0002676F
		public unsafe Gradient fogColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x0018BBFC File Offset: 0x00189DFC
		// (set) Token: 0x06005454 RID: 21588 RVA: 0x0002858E File Offset: 0x0002678E
		public unsafe AnimationCurve fogEndDistanceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06005455 RID: 21589 RVA: 0x0018BC2C File Offset: 0x00189E2C
		// (set) Token: 0x06005456 RID: 21590 RVA: 0x000285AD File Offset: 0x000267AD
		public unsafe float fogEndDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_fogEndDistanceMultiplier)) = value;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x0018BC54 File Offset: 0x00189E54
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x000285C8 File Offset: 0x000267C8
		public unsafe Gradient HeightFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x0018BC84 File Offset: 0x00189E84
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x000285E7 File Offset: 0x000267E7
		public unsafe AnimationCurve HeightFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x0018BCB4 File Offset: 0x00189EB4
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x00028606 File Offset: 0x00026806
		public unsafe float HeightFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x0018BCDC File Offset: 0x00189EDC
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x00028621 File Offset: 0x00026821
		public unsafe AnimationCurve HeightFogDirectionalIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x0018BD0C File Offset: 0x00189F0C
		// (set) Token: 0x06005460 RID: 21600 RVA: 0x00028640 File Offset: 0x00026840
		public unsafe Gradient VolumetricFogColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06005461 RID: 21601 RVA: 0x0018BD3C File Offset: 0x00189F3C
		// (set) Token: 0x06005462 RID: 21602 RVA: 0x0002865F File Offset: 0x0002685F
		public unsafe AnimationCurve VolumetricFogIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06005463 RID: 21603 RVA: 0x0018BD6C File Offset: 0x00189F6C
		// (set) Token: 0x06005464 RID: 21604 RVA: 0x0002867E File Offset: 0x0002687E
		public unsafe float VolumetricFogIntensityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_VolumetricFogIntensityMultiplier)) = value;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x0018BD94 File Offset: 0x00189F94
		// (set) Token: 0x06005466 RID: 21606 RVA: 0x00028699 File Offset: 0x00026899
		public unsafe AnimationCurve godRayIntensityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_godRayIntensityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06005467 RID: 21607 RVA: 0x0018BDC4 File Offset: 0x00189FC4
		// (set) Token: 0x06005468 RID: 21608 RVA: 0x000286B8 File Offset: 0x000268B8
		public unsafe AnimationCurve contrastCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contrastCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06005469 RID: 21609 RVA: 0x0018BDF4 File Offset: 0x00189FF4
		// (set) Token: 0x0600546A RID: 21610 RVA: 0x000286D7 File Offset: 0x000268D7
		public unsafe float contractMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_contractMultiplier)) = value;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x0600546B RID: 21611 RVA: 0x0018BE1C File Offset: 0x0018A01C
		// (set) Token: 0x0600546C RID: 21612 RVA: 0x000286F2 File Offset: 0x000268F2
		public unsafe AnimationCurve saturationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x0018BE4C File Offset: 0x0018A04C
		// (set) Token: 0x0600546E RID: 21614 RVA: 0x00028711 File Offset: 0x00026911
		public unsafe float saturationMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_saturationMultiplier)) = value;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x0600546F RID: 21615 RVA: 0x0018BE74 File Offset: 0x0018A074
		// (set) Token: 0x06005470 RID: 21616 RVA: 0x0002872C File Offset: 0x0002692C
		public unsafe Material grassMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06005471 RID: 21617 RVA: 0x0018BEA4 File Offset: 0x0018A0A4
		// (set) Token: 0x06005472 RID: 21618 RVA: 0x0002874B File Offset: 0x0002694B
		public unsafe Gradient grassColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_grassColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06005473 RID: 21619 RVA: 0x0018BED4 File Offset: 0x0018A0D4
		// (set) Token: 0x06005474 RID: 21620 RVA: 0x0002876A File Offset: 0x0002696A
		public unsafe Material distanceTreeMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06005475 RID: 21621 RVA: 0x0018BF04 File Offset: 0x0018A104
		// (set) Token: 0x06005476 RID: 21622 RVA: 0x00028789 File Offset: 0x00026989
		public unsafe AnimationCurve distanceTreeColorCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_distanceTreeColorCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06005477 RID: 21623 RVA: 0x0018BF34 File Offset: 0x0018A134
		// (set) Token: 0x06005478 RID: 21624 RVA: 0x000287A8 File Offset: 0x000269A8
		public unsafe AnimationCurve environmentalBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_environmentalBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x0018BF64 File Offset: 0x0018A164
		// (set) Token: 0x0600547A RID: 21626 RVA: 0x000287C7 File Offset: 0x000269C7
		public unsafe AnimationCurve bloomThreshholdCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_bloomThreshholdCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x0018BF94 File Offset: 0x0018A194
		// (set) Token: 0x0600547C RID: 21628 RVA: 0x000287E6 File Offset: 0x000269E6
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600547D RID: 21629 RVA: 0x0018BFBC File Offset: 0x0018A1BC
		// (set) Token: 0x0600547E RID: 21630 RVA: 0x00028801 File Offset: 0x00026A01
		public unsafe FloatSmoother FogEndDistanceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvironmentFX.NativeFieldInfoPtr_FogEndDistanceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeFieldInfoPtr_windZone;

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeFieldInfoPtr_timeOfDayController;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeFieldInfoPtr_HeightFog;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFog;

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeFieldInfoPtr_SunLight;

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeFieldInfoPtr_MoonLight;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeFieldInfoPtr_fogColorGradient;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceCurve;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeFieldInfoPtr_fogEndDistanceMultiplier;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogColor;

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityCurve;

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogIntensityMultiplier;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeFieldInfoPtr_HeightFogDirectionalIntensityCurve;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogColor;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityCurve;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeFieldInfoPtr_VolumetricFogIntensityMultiplier;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeFieldInfoPtr_godRayIntensityCurve;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeFieldInfoPtr_contrastCurve;

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeFieldInfoPtr_contractMultiplier;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeFieldInfoPtr_saturationCurve;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeFieldInfoPtr_saturationMultiplier;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeFieldInfoPtr_grassMat;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeFieldInfoPtr_grassColorGradient;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeMat;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeFieldInfoPtr_distanceTreeColorCurve;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeFieldInfoPtr_environmentalBrightnessCurve;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeFieldInfoPtr_bloomThreshholdCurve;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeFieldInfoPtr_FogEndDistanceController;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedEnvironmentalBrightness_Public_get_Single_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
