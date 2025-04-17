using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000504 RID: 1284
	public class Sensor : MonoBehaviour
	{
		// Token: 0x06007100 RID: 28928 RVA: 0x001F0394 File Offset: 0x001EE594
		// Note: this type is marked as 'beforefieldinit'.
		static Sensor()
		{
			Il2CppClassPointerStore<Sensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "Sensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sensor>.NativeClassPtr);
			Sensor.NativeFieldInfoPtr_obstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstruction");
			Sensor.NativeFieldInfoPtr_obstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstructionDistance");
			Sensor.NativeFieldInfoPtr_checkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRate");
			Sensor.NativeFieldInfoPtr_minDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "minDetectionRange");
			Sensor.NativeFieldInfoPtr_maxDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "maxDetectionRange");
			Sensor.NativeFieldInfoPtr_checkRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRadius");
			Sensor.NativeFieldInfoPtr_checkMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkMask");
			Sensor.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "vehicle");
			Sensor.NativeFieldInfoPtr_calculatedDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "calculatedDetectionRange");
			Sensor.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hit");
			Sensor.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hits");
			Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677516);
			Sensor.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677517);
			Sensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677518);
			Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100677519);
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x001F04F0 File Offset: 0x001EE6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222175, XrefRangeEnd = 222182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x001F052C File Offset: 0x001EE72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222182, XrefRangeEnd = 222284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x001F0560 File Offset: 0x001EE760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222284, XrefRangeEnd = 222292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x001F059C File Offset: 0x001EE79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222292, XrefRangeEnd = 222298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Check_b__12_0(RaycastHit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x00035A78 File Offset: 0x00033C78
		public Sensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x001F05E8 File Offset: 0x001EE7E8
		// (set) Token: 0x06007107 RID: 28935 RVA: 0x00035A81 File Offset: 0x00033C81
		public unsafe Collider obstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x001F0618 File Offset: 0x001EE818
		// (set) Token: 0x06007109 RID: 28937 RVA: 0x00035AA0 File Offset: 0x00033CA0
		public unsafe float obstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance)) = value;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x001F0640 File Offset: 0x001EE840
		// (set) Token: 0x0600710B RID: 28939 RVA: 0x00035ABB File Offset: 0x00033CBB
		public unsafe static float checkRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&value));
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600710C RID: 28940 RVA: 0x001F065C File Offset: 0x001EE85C
		// (set) Token: 0x0600710D RID: 28941 RVA: 0x00035AC9 File Offset: 0x00033CC9
		public unsafe float minDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange)) = value;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600710E RID: 28942 RVA: 0x001F0684 File Offset: 0x001EE884
		// (set) Token: 0x0600710F RID: 28943 RVA: 0x00035AE4 File Offset: 0x00033CE4
		public unsafe float maxDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange)) = value;
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06007110 RID: 28944 RVA: 0x001F06AC File Offset: 0x001EE8AC
		// (set) Token: 0x06007111 RID: 28945 RVA: 0x00035AFF File Offset: 0x00033CFF
		public unsafe float checkRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius)) = value;
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06007112 RID: 28946 RVA: 0x001F06D4 File Offset: 0x001EE8D4
		// (set) Token: 0x06007113 RID: 28947 RVA: 0x00035B1A File Offset: 0x00033D1A
		public unsafe LayerMask checkMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask)) = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06007114 RID: 28948 RVA: 0x001F06FC File Offset: 0x001EE8FC
		// (set) Token: 0x06007115 RID: 28949 RVA: 0x00035B35 File Offset: 0x00033D35
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x06007116 RID: 28950 RVA: 0x001F072C File Offset: 0x001EE92C
		// (set) Token: 0x06007117 RID: 28951 RVA: 0x00035B54 File Offset: 0x00033D54
		public unsafe float calculatedDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange)) = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x001F0754 File Offset: 0x001EE954
		// (set) Token: 0x06007119 RID: 28953 RVA: 0x00035B6F File Offset: 0x00033D6F
		public unsafe RaycastHit hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit)) = value;
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600711A RID: 28954 RVA: 0x001F077C File Offset: 0x001EE97C
		// (set) Token: 0x0600711B RID: 28955 RVA: 0x00035B8A File Offset: 0x00033D8A
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeFieldInfoPtr_obstruction;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeFieldInfoPtr_obstructionDistance;

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeFieldInfoPtr_checkRate;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeFieldInfoPtr_minDetectionRange;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_maxDetectionRange;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeFieldInfoPtr_checkRadius;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeFieldInfoPtr_checkMask;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeFieldInfoPtr_calculatedDetectionRange;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeMethodInfoPtr__Check_b__12_0_Private_Single_RaycastHit_0;
	}
}
