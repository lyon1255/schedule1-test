using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Lighting;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x02000789 RID: 1929
	public class StreetLight : MonoBehaviour
	{
		// Token: 0x0600B6A0 RID: 46752 RVA: 0x002D5550 File Offset: 0x002D3750
		// Note: this type is marked as 'beforefieldinit'.
		static StreetLight()
		{
			Il2CppClassPointerStore<StreetLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "StreetLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetLight>.NativeClassPtr);
			StreetLight.NativeFieldInfoPtr_POWER_ORIGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "POWER_ORIGIN");
			StreetLight.NativeFieldInfoPtr_LightRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightRend");
			StreetLight.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "Light");
			StreetLight.NativeFieldInfoPtr_BeamTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "BeamTracker");
			StreetLight.NativeFieldInfoPtr_LightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOnMat");
			StreetLight.NativeFieldInfoPtr_LightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightOffMat");
			StreetLight.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTime");
			StreetLight.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "EndTime");
			StreetLight.NativeFieldInfoPtr_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "StartTimeOffset");
			StreetLight.NativeFieldInfoPtr_ShadowsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "ShadowsEnabled");
			StreetLight.NativeFieldInfoPtr_LightMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "LightMaxDistance");
			StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "SoftShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_HardShadowsThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "HardShadowsThreshold");
			StreetLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, "isOn");
			StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685746);
			StreetLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685747);
			StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685748);
			StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685749);
			StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685750);
			StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685751);
			StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetLight>.NativeClassPtr, 100685752);
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x002D5724 File Offset: 0x002D3924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311396, XrefRangeEnd = 311424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x002D5760 File Offset: 0x002D3960
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x002D5794 File Offset: 0x002D3994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311424, XrefRangeEnd = 311436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreetLight.NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x002D57D0 File Offset: 0x002D39D0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x002D5804 File Offset: 0x002D3A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311464, RefRangeEnd = 311465, XrefRangeStart = 311436, XrefRangeEnd = 311464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_SetState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x002D5844 File Offset: 0x002D3A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311484, RefRangeEnd = 311485, XrefRangeStart = 311465, XrefRangeEnd = 311484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShadows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr_UpdateShadows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x002D5878 File Offset: 0x002D3A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311485, XrefRangeEnd = 311486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreetLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00059B01 File Offset: 0x00057D01
		public StreetLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600B6A9 RID: 46761 RVA: 0x002D58B4 File Offset: 0x002D3AB4
		// (set) Token: 0x0600B6AA RID: 46762 RVA: 0x00059B0A File Offset: 0x00057D0A
		public unsafe static Vector3 POWER_ORIGIN
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreetLight.NativeFieldInfoPtr_POWER_ORIGIN, (void*)(&value));
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600B6AB RID: 46763 RVA: 0x002D58D0 File Offset: 0x002D3AD0
		// (set) Token: 0x0600B6AC RID: 46764 RVA: 0x00059B18 File Offset: 0x00057D18
		public unsafe MeshRenderer LightRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600B6AD RID: 46765 RVA: 0x002D5900 File Offset: 0x002D3B00
		// (set) Token: 0x0600B6AE RID: 46766 RVA: 0x00059B37 File Offset: 0x00057D37
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600B6AF RID: 46767 RVA: 0x002D5930 File Offset: 0x002D3B30
		// (set) Token: 0x0600B6B0 RID: 46768 RVA: 0x00059B56 File Offset: 0x00057D56
		public unsafe VolumetricLightTracker BeamTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_BeamTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600B6B1 RID: 46769 RVA: 0x002D5960 File Offset: 0x002D3B60
		// (set) Token: 0x0600B6B2 RID: 46770 RVA: 0x00059B75 File Offset: 0x00057D75
		public unsafe Material LightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600B6B3 RID: 46771 RVA: 0x002D5990 File Offset: 0x002D3B90
		// (set) Token: 0x0600B6B4 RID: 46772 RVA: 0x00059B94 File Offset: 0x00057D94
		public unsafe Material LightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600B6B5 RID: 46773 RVA: 0x002D59C0 File Offset: 0x002D3BC0
		// (set) Token: 0x0600B6B6 RID: 46774 RVA: 0x00059BB3 File Offset: 0x00057DB3
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x170038A9 RID: 14505
		// (get) Token: 0x0600B6B7 RID: 46775 RVA: 0x002D59E8 File Offset: 0x002D3BE8
		// (set) Token: 0x0600B6B8 RID: 46776 RVA: 0x00059BCE File Offset: 0x00057DCE
		public unsafe int EndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x170038AA RID: 14506
		// (get) Token: 0x0600B6B9 RID: 46777 RVA: 0x002D5A10 File Offset: 0x002D3C10
		// (set) Token: 0x0600B6BA RID: 46778 RVA: 0x00059BE9 File Offset: 0x00057DE9
		public unsafe int StartTimeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_StartTimeOffset)) = value;
			}
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x002D5A38 File Offset: 0x002D3C38
		// (set) Token: 0x0600B6BC RID: 46780 RVA: 0x00059C04 File Offset: 0x00057E04
		public unsafe bool ShadowsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_ShadowsEnabled)) = value;
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600B6BD RID: 46781 RVA: 0x002D5A60 File Offset: 0x002D3C60
		// (set) Token: 0x0600B6BE RID: 46782 RVA: 0x00059C1F File Offset: 0x00057E1F
		public unsafe float LightMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_LightMaxDistance)) = value;
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x002D5A88 File Offset: 0x002D3C88
		// (set) Token: 0x0600B6C0 RID: 46784 RVA: 0x00059C3A File Offset: 0x00057E3A
		public unsafe float SoftShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_SoftShadowsThreshold)) = value;
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x002D5AB0 File Offset: 0x002D3CB0
		// (set) Token: 0x0600B6C2 RID: 46786 RVA: 0x00059C55 File Offset: 0x00057E55
		public unsafe float HardShadowsThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_HardShadowsThreshold)) = value;
			}
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600B6C3 RID: 46787 RVA: 0x002D5AD8 File Offset: 0x002D3CD8
		// (set) Token: 0x0600B6C4 RID: 46788 RVA: 0x00059C70 File Offset: 0x00057E70
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreetLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x04007B03 RID: 31491
		private static readonly IntPtr NativeFieldInfoPtr_POWER_ORIGIN;

		// Token: 0x04007B04 RID: 31492
		private static readonly IntPtr NativeFieldInfoPtr_LightRend;

		// Token: 0x04007B05 RID: 31493
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007B06 RID: 31494
		private static readonly IntPtr NativeFieldInfoPtr_BeamTracker;

		// Token: 0x04007B07 RID: 31495
		private static readonly IntPtr NativeFieldInfoPtr_LightOnMat;

		// Token: 0x04007B08 RID: 31496
		private static readonly IntPtr NativeFieldInfoPtr_LightOffMat;

		// Token: 0x04007B09 RID: 31497
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04007B0A RID: 31498
		private static readonly IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04007B0B RID: 31499
		private static readonly IntPtr NativeFieldInfoPtr_StartTimeOffset;

		// Token: 0x04007B0C RID: 31500
		private static readonly IntPtr NativeFieldInfoPtr_ShadowsEnabled;

		// Token: 0x04007B0D RID: 31501
		private static readonly IntPtr NativeFieldInfoPtr_LightMaxDistance;

		// Token: 0x04007B0E RID: 31502
		private static readonly IntPtr NativeFieldInfoPtr_SoftShadowsThreshold;

		// Token: 0x04007B0F RID: 31503
		private static readonly IntPtr NativeFieldInfoPtr_HardShadowsThreshold;

		// Token: 0x04007B10 RID: 31504
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x04007B11 RID: 31505
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007B12 RID: 31506
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007B13 RID: 31507
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Protected_Virtual_New_Void_0;

		// Token: 0x04007B14 RID: 31508
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007B15 RID: 31509
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_Boolean_0;

		// Token: 0x04007B16 RID: 31510
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShadows_Private_Void_0;

		// Token: 0x04007B17 RID: 31511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
