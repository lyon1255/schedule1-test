using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000056 RID: 86
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x000847C8 File Offset: 0x000829C8
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAdaptationComponent()
		{
			Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "EyeAdaptationComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr);
			EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_EyeCompute");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_HistogramBuffer");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_AutoExposurePool");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_AutoExposurePingPing");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_CurrentAutoExposure");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_DebugHistogram");
			EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "s_EmptyHistogramBuffer");
			EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "m_FirstFrame");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramBins");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramThreadX");
			EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "k_HistogramThreadY");
			EyeAdaptationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663954);
			EyeAdaptationComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663955);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663956);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663957);
			EyeAdaptationComponent.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663958);
			EyeAdaptationComponent.NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663959);
			EyeAdaptationComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663960);
			EyeAdaptationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, 100663961);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00084974 File Offset: 0x00082B74
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76668, XrefRangeEnd = 76670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000849B0 File Offset: 0x00082BB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57567, RefRangeEnd = 57569, XrefRangeStart = 57567, XrefRangeEnd = 57569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000849E4 File Offset: 0x00082BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57567, RefRangeEnd = 57569, XrefRangeStart = 57567, XrefRangeEnd = 57569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00084A18 File Offset: 0x00082C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76670, XrefRangeEnd = 76682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00084A4C File Offset: 0x00082C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76682, XrefRangeEnd = 76687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetHistogramScaleOffsetRes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00084A88 File Offset: 0x00082C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76822, RefRangeEnd = 76823, XrefRangeStart = 76687, XrefRangeEnd = 76822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00084AEC File Offset: 0x00082CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76834, RefRangeEnd = 76835, XrefRangeStart = 76823, XrefRangeEnd = 76834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00084B20 File Offset: 0x00082D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76842, RefRangeEnd = 76843, XrefRangeStart = 76835, XrefRangeEnd = 76842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeAdaptationComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAdaptationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00005C9F File Offset: 0x00003E9F
		public EyeAdaptationComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00084B5C File Offset: 0x00082D5C
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public unsafe ComputeShader m_EyeCompute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_EyeCompute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00084B8C File Offset: 0x00082D8C
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00005CC7 File Offset: 0x00003EC7
		public unsafe ComputeBuffer m_HistogramBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_HistogramBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00084BBC File Offset: 0x00082DBC
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00005CE6 File Offset: 0x00003EE6
		public unsafe Il2CppReferenceArray<RenderTexture> m_AutoExposurePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00084BEC File Offset: 0x00082DEC
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00005D05 File Offset: 0x00003F05
		public unsafe int m_AutoExposurePingPing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_AutoExposurePingPing)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00084C14 File Offset: 0x00082E14
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005D20 File Offset: 0x00003F20
		public unsafe RenderTexture m_CurrentAutoExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_CurrentAutoExposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00084C44 File Offset: 0x00082E44
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00005D3F File Offset: 0x00003F3F
		public unsafe RenderTexture m_DebugHistogram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_DebugHistogram), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00084C74 File Offset: 0x00082E74
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00005D5E File Offset: 0x00003F5E
		public unsafe static Il2CppStructArray<uint> s_EmptyHistogramBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_s_EmptyHistogramBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00084C9C File Offset: 0x00082E9C
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00005D70 File Offset: 0x00003F70
		public unsafe bool m_FirstFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAdaptationComponent.NativeFieldInfoPtr_m_FirstFrame)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00084CC4 File Offset: 0x00082EC4
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005D8B File Offset: 0x00003F8B
		public unsafe static int k_HistogramBins
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramBins, (void*)(&value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00084CE0 File Offset: 0x00082EE0
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00005D99 File Offset: 0x00003F99
		public unsafe static int k_HistogramThreadX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadX, (void*)(&value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00084CFC File Offset: 0x00082EFC
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00005DA7 File Offset: 0x00003FA7
		public unsafe static int k_HistogramThreadY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.NativeFieldInfoPtr_k_HistogramThreadY, (void*)(&value));
			}
		}

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_m_EyeCompute;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_m_HistogramBuffer;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePool;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_m_AutoExposurePingPing;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAutoExposure;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugHistogram;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyHistogramBuffer;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstFrame;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramBins;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramThreadX;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_k_HistogramThreadY;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Virtual_Void_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_GetHistogramScaleOffsetRes_Private_Vector4_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Texture_RenderTexture_Material_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CD RID: 1997
		public static class Uniforms : Object
		{
			// Token: 0x0600BB5E RID: 47966 RVA: 0x002E5570 File Offset: 0x002E3770
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeAdaptationComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr);
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_Params");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_Speed");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_ScaleOffsetRes");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_ExposureCompensation");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_AutoExposure");
				EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAdaptationComponent.Uniforms>.NativeClassPtr, "_DebugWidth");
			}

			// Token: 0x0600BB5F RID: 47967 RVA: 0x0005BAC2 File Offset: 0x00059CC2
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039F3 RID: 14835
			// (get) Token: 0x0600BB60 RID: 47968 RVA: 0x002E5614 File Offset: 0x002E3814
			// (set) Token: 0x0600BB61 RID: 47969 RVA: 0x0005BACB File Offset: 0x00059CCB
			public unsafe static int _Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Params, (void*)(&value));
				}
			}

			// Token: 0x170039F4 RID: 14836
			// (get) Token: 0x0600BB62 RID: 47970 RVA: 0x002E5630 File Offset: 0x002E3830
			// (set) Token: 0x0600BB63 RID: 47971 RVA: 0x0005BAD9 File Offset: 0x00059CD9
			public unsafe static int _Speed
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__Speed, (void*)(&value));
				}
			}

			// Token: 0x170039F5 RID: 14837
			// (get) Token: 0x0600BB64 RID: 47972 RVA: 0x002E564C File Offset: 0x002E384C
			// (set) Token: 0x0600BB65 RID: 47973 RVA: 0x0005BAE7 File Offset: 0x00059CE7
			public unsafe static int _ScaleOffsetRes
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ScaleOffsetRes, (void*)(&value));
				}
			}

			// Token: 0x170039F6 RID: 14838
			// (get) Token: 0x0600BB66 RID: 47974 RVA: 0x002E5668 File Offset: 0x002E3868
			// (set) Token: 0x0600BB67 RID: 47975 RVA: 0x0005BAF5 File Offset: 0x00059CF5
			public unsafe static int _ExposureCompensation
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__ExposureCompensation, (void*)(&value));
				}
			}

			// Token: 0x170039F7 RID: 14839
			// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x002E5684 File Offset: 0x002E3884
			// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x0005BB03 File Offset: 0x00059D03
			public unsafe static int _AutoExposure
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&value));
				}
			}

			// Token: 0x170039F8 RID: 14840
			// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x002E56A0 File Offset: 0x002E38A0
			// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x0005BB11 File Offset: 0x00059D11
			public unsafe static int _DebugWidth
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EyeAdaptationComponent.Uniforms.NativeFieldInfoPtr__DebugWidth, (void*)(&value));
				}
			}

			// Token: 0x04007E47 RID: 32327
			private static readonly IntPtr NativeFieldInfoPtr__Params;

			// Token: 0x04007E48 RID: 32328
			private static readonly IntPtr NativeFieldInfoPtr__Speed;

			// Token: 0x04007E49 RID: 32329
			private static readonly IntPtr NativeFieldInfoPtr__ScaleOffsetRes;

			// Token: 0x04007E4A RID: 32330
			private static readonly IntPtr NativeFieldInfoPtr__ExposureCompensation;

			// Token: 0x04007E4B RID: 32331
			private static readonly IntPtr NativeFieldInfoPtr__AutoExposure;

			// Token: 0x04007E4C RID: 32332
			private static readonly IntPtr NativeFieldInfoPtr__DebugWidth;
		}
	}
}
