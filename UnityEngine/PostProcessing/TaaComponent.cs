using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005C RID: 92
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x0600070A RID: 1802 RVA: 0x00085A34 File Offset: 0x00083C34
		// Note: this type is marked as 'beforefieldinit'.
		static TaaComponent()
		{
			Il2CppClassPointerStore<TaaComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "TaaComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr);
			TaaComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "k_ShaderString");
			TaaComponent.NativeFieldInfoPtr_k_SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "k_SampleCount");
			TaaComponent.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_MRT");
			TaaComponent.NativeFieldInfoPtr_m_SampleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_SampleIndex");
			TaaComponent.NativeFieldInfoPtr_m_ResetHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_ResetHistory");
			TaaComponent.NativeFieldInfoPtr_m_HistoryTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "m_HistoryTexture");
			TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "<jitterVector>k__BackingField");
			TaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664014);
			TaaComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664015);
			TaaComponent.NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664016);
			TaaComponent.NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664017);
			TaaComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664018);
			TaaComponent.NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664019);
			TaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664020);
			TaaComponent.NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664021);
			TaaComponent.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664022);
			TaaComponent.NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664023);
			TaaComponent.NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664024);
			TaaComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664025);
			TaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, 100664026);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00085BF4 File Offset: 0x00083DF4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77535, XrefRangeEnd = 77538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00085C30 File Offset: 0x00083E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77277, RefRangeEnd = 77278, XrefRangeStart = 77277, XrefRangeEnd = 77278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00085C6C File Offset: 0x00083E6C
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00085CA8 File Offset: 0x00083EA8
		public unsafe Vector2 jitterVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00085CE8 File Offset: 0x00083EE8
		[CallerCount(0)]
		public unsafe void ResetHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_ResetHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00085D1C File Offset: 0x00083F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77564, RefRangeEnd = 77565, XrefRangeStart = 77538, XrefRangeEnd = 77564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(jitteredFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00085D60 File Offset: 0x00083F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77626, RefRangeEnd = 77627, XrefRangeStart = 77565, XrefRangeEnd = 77626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00085DB4 File Offset: 0x00083FB4
		[CallerCount(0)]
		public unsafe float GetHaltonValue(int index, int radix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00085E0C File Offset: 0x0008400C
		[CallerCount(0)]
		public unsafe Vector2 GenerateRandomOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00085E48 File Offset: 0x00084048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77662, RefRangeEnd = 77663, XrefRangeStart = 77627, XrefRangeEnd = 77662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00085E94 File Offset: 0x00084094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77663, XrefRangeEnd = 77670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00085EE0 File Offset: 0x000840E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77670, XrefRangeEnd = 77676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00085F14 File Offset: 0x00084114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77676, XrefRangeEnd = 77683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaaComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00005EF7 File Offset: 0x000040F7
		public TaaComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00085F50 File Offset: 0x00084150
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00005F00 File Offset: 0x00004100
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaaComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaaComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00085F70 File Offset: 0x00084170
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00005F12 File Offset: 0x00004112
		public unsafe static int k_SampleCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TaaComponent.NativeFieldInfoPtr_k_SampleCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaaComponent.NativeFieldInfoPtr_k_SampleCount, (void*)(&value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00085F8C File Offset: 0x0008418C
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00005F20 File Offset: 0x00004120
		public unsafe Il2CppStructArray<RenderBuffer> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBuffer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00085FBC File Offset: 0x000841BC
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00005F3F File Offset: 0x0000413F
		public unsafe int m_SampleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_SampleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_SampleIndex)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00085FE4 File Offset: 0x000841E4
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00005F5A File Offset: 0x0000415A
		public unsafe bool m_ResetHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_ResetHistory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_ResetHistory)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x0008600C File Offset: 0x0008420C
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00005F75 File Offset: 0x00004175
		public unsafe RenderTexture m_HistoryTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_HistoryTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr_m_HistoryTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x0008603C File Offset: 0x0008423C
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00005F94 File Offset: 0x00004194
		public unsafe Vector2 _jitterVector_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaaComponent.NativeFieldInfoPtr__jitterVector_k__BackingField)) = value;
			}
		}

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_k_SampleCount;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_m_SampleIndex;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_m_ResetHistory;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_m_HistoryTexture;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr__jitterVector_k__BackingField;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_jitterVector_Public_get_Vector2_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_jitterVector_Private_set_Void_Vector2_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_ResetHistory_Public_Void_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectionMatrix_Public_Void_Func_2_Vector2_Matrix4x4_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_GetHaltonValue_Private_Single_Int32_Int32_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomOffset_Private_Vector2_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_GetPerspectiveProjectionMatrix_Private_Matrix4x4_Vector2_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_GetOrthographicProjectionMatrix_Private_Matrix4x4_Vector2_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D7 RID: 2007
		public static class Uniforms : Object
		{
			// Token: 0x0600BC21 RID: 48161 RVA: 0x002E6B10 File Offset: 0x002E4D10
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaaComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr);
				TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_Jitter");
				TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_SharpenParameters");
				TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_FinalBlendParameters");
				TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_HistoryTex");
				TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaComponent.Uniforms>.NativeClassPtr, "_MainTex");
			}

			// Token: 0x0600BC22 RID: 48162 RVA: 0x0005BFF4 File Offset: 0x0005A1F4
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A47 RID: 14919
			// (get) Token: 0x0600BC23 RID: 48163 RVA: 0x002E6BA0 File Offset: 0x002E4DA0
			// (set) Token: 0x0600BC24 RID: 48164 RVA: 0x0005BFFD File Offset: 0x0005A1FD
			public unsafe static int _Jitter
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__Jitter, (void*)(&value));
				}
			}

			// Token: 0x17003A48 RID: 14920
			// (get) Token: 0x0600BC25 RID: 48165 RVA: 0x002E6BBC File Offset: 0x002E4DBC
			// (set) Token: 0x0600BC26 RID: 48166 RVA: 0x0005C00B File Offset: 0x0005A20B
			public unsafe static int _SharpenParameters
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__SharpenParameters, (void*)(&value));
				}
			}

			// Token: 0x17003A49 RID: 14921
			// (get) Token: 0x0600BC27 RID: 48167 RVA: 0x002E6BD8 File Offset: 0x002E4DD8
			// (set) Token: 0x0600BC28 RID: 48168 RVA: 0x0005C019 File Offset: 0x0005A219
			public unsafe static int _FinalBlendParameters
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__FinalBlendParameters, (void*)(&value));
				}
			}

			// Token: 0x17003A4A RID: 14922
			// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x002E6BF4 File Offset: 0x002E4DF4
			// (set) Token: 0x0600BC2A RID: 48170 RVA: 0x0005C027 File Offset: 0x0005A227
			public unsafe static int _HistoryTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__HistoryTex, (void*)(&value));
				}
			}

			// Token: 0x17003A4B RID: 14923
			// (get) Token: 0x0600BC2B RID: 48171 RVA: 0x002E6C10 File Offset: 0x002E4E10
			// (set) Token: 0x0600BC2C RID: 48172 RVA: 0x0005C035 File Offset: 0x0005A235
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaaComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x04007EBA RID: 32442
			private static readonly IntPtr NativeFieldInfoPtr__Jitter;

			// Token: 0x04007EBB RID: 32443
			private static readonly IntPtr NativeFieldInfoPtr__SharpenParameters;

			// Token: 0x04007EBC RID: 32444
			private static readonly IntPtr NativeFieldInfoPtr__FinalBlendParameters;

			// Token: 0x04007EBD RID: 32445
			private static readonly IntPtr NativeFieldInfoPtr__HistoryTex;

			// Token: 0x04007EBE RID: 32446
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;
		}
	}
}
