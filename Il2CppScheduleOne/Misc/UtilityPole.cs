using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076B RID: 1899
	public class UtilityPole : MonoBehaviour
	{
		// Token: 0x0600B445 RID: 46149 RVA: 0x002CE6C4 File Offset: 0x002CC8C4
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityPole()
		{
			Il2CppClassPointerStore<UtilityPole>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "UtilityPole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr);
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE");
			UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "CABLE_CULL_DISTANCE_SQR");
			UtilityPole.NativeFieldInfoPtr_previousPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "previousPole");
			UtilityPole.NativeFieldInfoPtr_nextPole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "nextPole");
			UtilityPole.NativeFieldInfoPtr_Connection1Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection1Enabled");
			UtilityPole.NativeFieldInfoPtr_Connection2Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Connection2Enabled");
			UtilityPole.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "LengthFactor");
			UtilityPole.NativeFieldInfoPtr_cable1Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Connection");
			UtilityPole.NativeFieldInfoPtr_cable2Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Connection");
			UtilityPole.NativeFieldInfoPtr_cable1Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable1Segments");
			UtilityPole.NativeFieldInfoPtr_cable2Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cable2Segments");
			UtilityPole.NativeFieldInfoPtr_Cable1Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable1Container");
			UtilityPole.NativeFieldInfoPtr_Cable2Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "Cable2Container");
			UtilityPole.NativeFieldInfoPtr_cableStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableStart");
			UtilityPole.NativeFieldInfoPtr_cableEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableEnd");
			UtilityPole.NativeFieldInfoPtr_cableMid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, "cableMid");
			UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685501);
			UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685502);
			UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685503);
			UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685504);
			UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685505);
			UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685506);
			UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr, 100685507);
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x002CE8C0 File Offset: 0x002CCAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309039, XrefRangeEnd = 309049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Awake_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x002CE8F4 File Offset: 0x002CCAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309049, XrefRangeEnd = 309073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x002CE928 File Offset: 0x002CCB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309073, XrefRangeEnd = 309101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_UpdateCulling_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x002CE95C File Offset: 0x002CCB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309101, XrefRangeEnd = 309151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Orient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Orient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x002CE990 File Offset: 0x002CCB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309151, XrefRangeEnd = 309219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_DrawLines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x002CE9C4 File Offset: 0x002CCBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309219, XrefRangeEnd = 309238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UtilityPole() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UtilityPole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x002CEA00 File Offset: 0x002CCC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309269, RefRangeEnd = 309270, XrefRangeStart = 309238, XrefRangeEnd = 309269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilityPole.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x00058614 File Offset: 0x00056814
		public UtilityPole(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600B44E RID: 46158 RVA: 0x002CEA34 File Offset: 0x002CCC34
		// (set) Token: 0x0600B44F RID: 46159 RVA: 0x0005861D File Offset: 0x0005681D
		public unsafe static float CABLE_CULL_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600B450 RID: 46160 RVA: 0x002CEA50 File Offset: 0x002CCC50
		// (set) Token: 0x0600B451 RID: 46161 RVA: 0x0005862B File Offset: 0x0005682B
		public unsafe static float CABLE_CULL_DISTANCE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UtilityPole.NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR, (void*)(&value));
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x002CEA6C File Offset: 0x002CCC6C
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x00058639 File Offset: 0x00056839
		public unsafe UtilityPole previousPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_previousPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x002CEA9C File Offset: 0x002CCC9C
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x00058658 File Offset: 0x00056858
		public unsafe UtilityPole nextPole
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UtilityPole>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_nextPole), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x002CEACC File Offset: 0x002CCCCC
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x00058677 File Offset: 0x00056877
		public unsafe bool Connection1Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection1Enabled)) = value;
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600B458 RID: 46168 RVA: 0x002CEAF4 File Offset: 0x002CCCF4
		// (set) Token: 0x0600B459 RID: 46169 RVA: 0x00058692 File Offset: 0x00056892
		public unsafe bool Connection2Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Connection2Enabled)) = value;
			}
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600B45A RID: 46170 RVA: 0x002CEB1C File Offset: 0x002CCD1C
		// (set) Token: 0x0600B45B RID: 46171 RVA: 0x000586AD File Offset: 0x000568AD
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B45C RID: 46172 RVA: 0x002CEB44 File Offset: 0x002CCD44
		// (set) Token: 0x0600B45D RID: 46173 RVA: 0x000586C8 File Offset: 0x000568C8
		public unsafe Transform cable1Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B45E RID: 46174 RVA: 0x002CEB74 File Offset: 0x002CCD74
		// (set) Token: 0x0600B45F RID: 46175 RVA: 0x000586E7 File Offset: 0x000568E7
		public unsafe Transform cable2Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B460 RID: 46176 RVA: 0x002CEBA4 File Offset: 0x002CCDA4
		// (set) Token: 0x0600B461 RID: 46177 RVA: 0x00058706 File Offset: 0x00056906
		public unsafe List<Transform> cable1Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable1Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x002CEBD4 File Offset: 0x002CCDD4
		// (set) Token: 0x0600B463 RID: 46179 RVA: 0x00058725 File Offset: 0x00056925
		public unsafe List<Transform> cable2Segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cable2Segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600B464 RID: 46180 RVA: 0x002CEC04 File Offset: 0x002CCE04
		// (set) Token: 0x0600B465 RID: 46181 RVA: 0x00058744 File Offset: 0x00056944
		public unsafe Transform Cable1Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable1Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600B466 RID: 46182 RVA: 0x002CEC34 File Offset: 0x002CCE34
		// (set) Token: 0x0600B467 RID: 46183 RVA: 0x00058763 File Offset: 0x00056963
		public unsafe Transform Cable2Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_Cable2Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x002CEC64 File Offset: 0x002CCE64
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x00058782 File Offset: 0x00056982
		public unsafe Vector3 cableStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableStart)) = value;
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x002CEC8C File Offset: 0x002CCE8C
		// (set) Token: 0x0600B46B RID: 46187 RVA: 0x0005879D File Offset: 0x0005699D
		public unsafe Vector3 cableEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableEnd)) = value;
			}
		}

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x002CECB4 File Offset: 0x002CCEB4
		// (set) Token: 0x0600B46D RID: 46189 RVA: 0x000587B8 File Offset: 0x000569B8
		public unsafe Vector3 cableMid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UtilityPole.NativeFieldInfoPtr_cableMid)) = value;
			}
		}

		// Token: 0x0400798C RID: 31116
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE;

		// Token: 0x0400798D RID: 31117
		private static readonly IntPtr NativeFieldInfoPtr_CABLE_CULL_DISTANCE_SQR;

		// Token: 0x0400798E RID: 31118
		private static readonly IntPtr NativeFieldInfoPtr_previousPole;

		// Token: 0x0400798F RID: 31119
		private static readonly IntPtr NativeFieldInfoPtr_nextPole;

		// Token: 0x04007990 RID: 31120
		private static readonly IntPtr NativeFieldInfoPtr_Connection1Enabled;

		// Token: 0x04007991 RID: 31121
		private static readonly IntPtr NativeFieldInfoPtr_Connection2Enabled;

		// Token: 0x04007992 RID: 31122
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04007993 RID: 31123
		private static readonly IntPtr NativeFieldInfoPtr_cable1Connection;

		// Token: 0x04007994 RID: 31124
		private static readonly IntPtr NativeFieldInfoPtr_cable2Connection;

		// Token: 0x04007995 RID: 31125
		private static readonly IntPtr NativeFieldInfoPtr_cable1Segments;

		// Token: 0x04007996 RID: 31126
		private static readonly IntPtr NativeFieldInfoPtr_cable2Segments;

		// Token: 0x04007997 RID: 31127
		private static readonly IntPtr NativeFieldInfoPtr_Cable1Container;

		// Token: 0x04007998 RID: 31128
		private static readonly IntPtr NativeFieldInfoPtr_Cable2Container;

		// Token: 0x04007999 RID: 31129
		private static readonly IntPtr NativeFieldInfoPtr_cableStart;

		// Token: 0x0400799A RID: 31130
		private static readonly IntPtr NativeFieldInfoPtr_cableEnd;

		// Token: 0x0400799B RID: 31131
		private static readonly IntPtr NativeFieldInfoPtr_cableMid;

		// Token: 0x0400799C RID: 31132
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_1;

		// Token: 0x0400799D RID: 31133
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x0400799E RID: 31134
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_1;

		// Token: 0x0400799F RID: 31135
		private static readonly IntPtr NativeMethodInfoPtr_Orient_Public_Void_0;

		// Token: 0x040079A0 RID: 31136
		private static readonly IntPtr NativeMethodInfoPtr_DrawLines_Public_Void_0;

		// Token: 0x040079A1 RID: 31137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079A2 RID: 31138
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
