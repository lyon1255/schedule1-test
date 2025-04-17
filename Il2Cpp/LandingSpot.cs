using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003D RID: 61
	public class LandingSpot : MonoBehaviour
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0007EA88 File Offset: 0x0007CC88
		// Note: this type is marked as 'beforefieldinit'.
		static LandingSpot()
		{
			Il2CppClassPointerStore<LandingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LandingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr);
			LandingSpot.NativeFieldInfoPtr_landingChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landingChild");
			LandingSpot.NativeFieldInfoPtr_landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "landing");
			LandingSpot.NativeFieldInfoPtr_lerpCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "lerpCounter");
			LandingSpot.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_controller");
			LandingSpot.NativeFieldInfoPtr__idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_idle");
			LandingSpot.NativeFieldInfoPtr__thisT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_thisT");
			LandingSpot.NativeFieldInfoPtr__gotcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "_gotcha");
			LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663703);
			LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663704);
			LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663705);
			LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663706);
			LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663707);
			LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663708);
			LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663709);
			LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663710);
			LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, 100663711);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0007EBF8 File Offset: 0x0007CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74482, XrefRangeEnd = 74498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0007EC2C File Offset: 0x0007CE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74498, XrefRangeEnd = 74541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0007EC60 File Offset: 0x0007CE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74541, XrefRangeEnd = 74583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0007EC94 File Offset: 0x0007CE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74583, XrefRangeEnd = 74586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StraightenBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_StraightenBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0007ECC8 File Offset: 0x0007CEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74601, RefRangeEnd = 74602, XrefRangeStart = 74586, XrefRangeEnd = 74601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateBird()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_RotateBird_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0007ECFC File Offset: 0x0007CEFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74607, RefRangeEnd = 74612, XrefRangeStart = 74602, XrefRangeEnd = 74607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetFlockChild(float minDelay, float maxDelay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDelay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0007ED58 File Offset: 0x0007CF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74612, XrefRangeEnd = 74634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_InstantLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0007ED8C File Offset: 0x0007CF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74634, XrefRangeEnd = 74659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFlockChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0007EDC0 File Offset: 0x0007CFC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00004EF7 File Offset: 0x000030F7
		public LandingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0007EDFC File Offset: 0x0007CFFC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004F00 File Offset: 0x00003100
		public unsafe FlockChild landingChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landingChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0007EE2C File Offset: 0x0007D02C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004F1F File Offset: 0x0000311F
		public unsafe bool landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_landing)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0007EE54 File Offset: 0x0007D054
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004F3A File Offset: 0x0000313A
		public unsafe int lerpCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr_lerpCounter)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0007EE7C File Offset: 0x0007D07C
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004F55 File Offset: 0x00003155
		public unsafe LandingSpotController _controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpotController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x0007EEAC File Offset: 0x0007D0AC
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004F74 File Offset: 0x00003174
		public unsafe bool _idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__idle)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00004F8F File Offset: 0x0000318F
		public unsafe Transform _thisT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__thisT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0007EF04 File Offset: 0x0007D104
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00004FAE File Offset: 0x000031AE
		public unsafe bool _gotcha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot.NativeFieldInfoPtr__gotcha)) = value;
			}
		}

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_landingChild;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_landing;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_lerpCounter;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr__controller;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr__idle;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr__thisT;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr__gotcha;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_StraightenBird_Public_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_RotateBird_Public_Void_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_GetFlockChild_Public_IEnumerator_Single_Single_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_InstantLand_Public_Void_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFlockChild_Public_Void_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B3 RID: 1971
		[ObfuscatedName("LandingSpot+<GetFlockChild>d__12")]
		public sealed class _GetFlockChild_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600B9BB RID: 47547 RVA: 0x002E16D4 File Offset: 0x002DF8D4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFlockChild_d__12()
			{
				Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandingSpot>.NativeClassPtr, "<GetFlockChild>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr);
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>1__state");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>2__current");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "minDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "maxDelay");
				LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, "<>4__this");
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663712);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663713);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663714);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663715);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663716);
				LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr, 100663717);
			}

			// Token: 0x0600B9BC RID: 47548 RVA: 0x002E17DC File Offset: 0x002DF9DC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFlockChild_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandingSpot._GetFlockChild_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9BD RID: 47549 RVA: 0x002E1824 File Offset: 0x002DFA24
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9BE RID: 47550 RVA: 0x002E1858 File Offset: 0x002DFA58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74443, XrefRangeEnd = 74477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003953 RID: 14675
			// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x002E1894 File Offset: 0x002DFA94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9C0 RID: 47552 RVA: 0x002E18D4 File Offset: 0x002DFAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74477, XrefRangeEnd = 74482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003954 RID: 14676
			// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x002E1908 File Offset: 0x002DFB08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandingSpot._GetFlockChild_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B9C2 RID: 47554 RVA: 0x0005ACD2 File Offset: 0x00058ED2
			public _GetFlockChild_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700394E RID: 14670
			// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x002E1948 File Offset: 0x002DFB48
			// (set) Token: 0x0600B9C4 RID: 47556 RVA: 0x0005ACDB File Offset: 0x00058EDB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700394F RID: 14671
			// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x002E1970 File Offset: 0x002DFB70
			// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x0005ACF6 File Offset: 0x00058EF6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003950 RID: 14672
			// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x002E19A0 File Offset: 0x002DFBA0
			// (set) Token: 0x0600B9C8 RID: 47560 RVA: 0x0005AD15 File Offset: 0x00058F15
			public unsafe float minDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_minDelay)) = value;
				}
			}

			// Token: 0x17003951 RID: 14673
			// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x002E19C8 File Offset: 0x002DFBC8
			// (set) Token: 0x0600B9CA RID: 47562 RVA: 0x0005AD30 File Offset: 0x00058F30
			public unsafe float maxDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr_maxDelay)) = value;
				}
			}

			// Token: 0x17003952 RID: 14674
			// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x002E19F0 File Offset: 0x002DFBF0
			// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x0005AD4B File Offset: 0x00058F4B
			public unsafe LandingSpot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandingSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LandingSpot._GetFlockChild_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D46 RID: 32070
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D47 RID: 32071
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D48 RID: 32072
			private static readonly IntPtr NativeFieldInfoPtr_minDelay;

			// Token: 0x04007D49 RID: 32073
			private static readonly IntPtr NativeFieldInfoPtr_maxDelay;

			// Token: 0x04007D4A RID: 32074
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007D4B RID: 32075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D4C RID: 32076
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D4D RID: 32077
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D4E RID: 32078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D4F RID: 32079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D50 RID: 32080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
