using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public sealed class ColorGradingCurve : Object
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0008A158 File Offset: 0x00088358
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGradingCurve()
		{
			Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ColorGradingCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr);
			ColorGradingCurve.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "curve");
			ColorGradingCurve.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_Loop");
			ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_ZeroValue");
			ColorGradingCurve.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_Range");
			ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, "m_InternalLoopingCurve");
			ColorGradingCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664186);
			ColorGradingCurve.NativeMethodInfoPtr_Cache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664187);
			ColorGradingCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr, 100664188);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0008A228 File Offset: 0x00088428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78908, XrefRangeEnd = 78911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingCurve>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(curve);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0008A2A0 File Offset: 0x000884A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78927, RefRangeEnd = 78929, XrefRangeStart = 78911, XrefRangeEnd = 78927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr_Cache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0008A2D4 File Offset: 0x000884D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 78933, RefRangeEnd = 78941, XrefRangeStart = 78929, XrefRangeEnd = 78933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGradingCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000068DF File Offset: 0x00004ADF
		public ColorGradingCurve(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0008A320 File Offset: 0x00088520
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000068E8 File Offset: 0x00004AE8
		public unsafe AnimationCurve curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0008A350 File Offset: 0x00088550
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00006907 File Offset: 0x00004B07
		public unsafe bool m_Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Loop)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0008A378 File Offset: 0x00088578
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00006922 File Offset: 0x00004B22
		public unsafe float m_ZeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_ZeroValue)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0008A3A0 File Offset: 0x000885A0
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0000693D File Offset: 0x00004B3D
		public unsafe float m_Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_Range)) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0008A3C8 File Offset: 0x000885C8
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00006958 File Offset: 0x00004B58
		public unsafe AnimationCurve m_InternalLoopingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorGradingCurve.NativeFieldInfoPtr_m_InternalLoopingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_curve;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_m_ZeroValue;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLoopingCurve;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_Vector2_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_Cache_Public_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;
	}
}
