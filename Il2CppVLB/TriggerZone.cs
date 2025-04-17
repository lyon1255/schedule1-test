using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000B4 RID: 180
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x0009AC70 File Offset: 0x00098E70
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerZone()
		{
			Il2CppClassPointerStore<TriggerZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TriggerZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr);
			TriggerZone.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "ClassName");
			TriggerZone.NativeFieldInfoPtr_setIsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "setIsTrigger");
			TriggerZone.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "rangeMultiplier");
			TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "kMeshColliderNumSides");
			TriggerZone.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_Beam");
			TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_DynamicOcclusionRaycasting");
			TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_PolygonCollider2D");
			TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664916);
			TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664917);
			TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664918);
			TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664919);
			TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100664920);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0009AD90 File Offset: 0x00098F90
		public unsafe TriggerZone.TriggerZoneUpdateRate updateRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84485, XrefRangeEnd = 84490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x0009ADCC File Offset: 0x00098FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84490, XrefRangeEnd = 84517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0009AE00 File Offset: 0x00099000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84517, XrefRangeEnd = 84518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOcclusionProcessed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x0009AE34 File Offset: 0x00099034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84556, RefRangeEnd = 84557, XrefRangeStart = 84518, XrefRangeEnd = 84556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_ComputeZone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0009AE68 File Offset: 0x00099068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84557, XrefRangeEnd = 84558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000087EC File Offset: 0x000069EC
		public TriggerZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x0009AEA4 File Offset: 0x000990A4
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x000087F5 File Offset: 0x000069F5
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0009AEC4 File Offset: 0x000990C4
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00008807 File Offset: 0x00006A07
		public unsafe bool setIsTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger)) = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0009AEEC File Offset: 0x000990EC
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00008822 File Offset: 0x00006A22
		public unsafe float rangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier)) = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0009AF14 File Offset: 0x00099114
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x0000883D File Offset: 0x00006A3D
		public unsafe static int kMeshColliderNumSides
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0009AF30 File Offset: 0x00099130
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0000884B File Offset: 0x00006A4B
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x0009AF60 File Offset: 0x00099160
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x0000886A File Offset: 0x00006A6A
		public unsafe DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicOcclusionRaycasting>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_DynamicOcclusionRaycasting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0009AF90 File Offset: 0x00099190
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00008889 File Offset: 0x00006A89
		public unsafe PolygonCollider2D m_PolygonCollider2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_PolygonCollider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_setIsTrigger;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_kMeshColliderNumSides;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicOcclusionRaycasting;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_m_PolygonCollider2D;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Private_get_TriggerZoneUpdateRate_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_OnOcclusionProcessed_Private_Void_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_ComputeZone_Private_Void_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200083C RID: 2108
		[OriginalName("Assembly-CSharp.dll", "", "TriggerZoneUpdateRate")]
		public enum TriggerZoneUpdateRate
		{
			// Token: 0x040081B9 RID: 33209
			OnEnable,
			// Token: 0x040081BA RID: 33210
			OnOcclusionChange
		}
	}
}
