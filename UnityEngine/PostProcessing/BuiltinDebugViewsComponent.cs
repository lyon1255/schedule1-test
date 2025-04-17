using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000051 RID: 81
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x000831D8 File Offset: 0x000813D8
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinDebugViewsComponent()
		{
			Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BuiltinDebugViewsComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr);
			BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "k_ShaderString");
			BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "m_Arrows");
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663888);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663889);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663890);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663891);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663892);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663893);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663894);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663895);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_PrepareArrows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663896);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663897);
			BuiltinDebugViewsComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, 100663898);
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0008330C File Offset: 0x0008150C
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76073, XrefRangeEnd = 76077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00083348 File Offset: 0x00081548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76077, XrefRangeEnd = 76078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00083384 File Offset: 0x00081584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76078, XrefRangeEnd = 76079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000833C0 File Offset: 0x000815C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76079, XrefRangeEnd = 76081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000833F8 File Offset: 0x000815F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76081, XrefRangeEnd = 76110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0008343C File Offset: 0x0008163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76110, XrefRangeEnd = 76121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepthPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00083480 File Offset: 0x00081680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76121, XrefRangeEnd = 76126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepthNormalsPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000834C4 File Offset: 0x000816C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76196, RefRangeEnd = 76197, XrefRangeStart = 76126, XrefRangeEnd = 76196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MotionVectorsPass(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00083508 File Offset: 0x00081708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76197, XrefRangeEnd = 76208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareArrows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_PrepareArrows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0008353C File Offset: 0x0008173C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76208, XrefRangeEnd = 76211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00083570 File Offset: 0x00081770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76214, RefRangeEnd = 76215, XrefRangeStart = 76211, XrefRangeEnd = 76214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinDebugViewsComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00005B33 File Offset: 0x00003D33
		public BuiltinDebugViewsComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000835AC File Offset: 0x000817AC
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00005B3C File Offset: 0x00003D3C
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000835CC File Offset: 0x000817CC
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00005B4E File Offset: 0x00003D4E
		public unsafe BuiltinDebugViewsComponent.ArrowArray m_Arrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuiltinDebugViewsComponent.ArrowArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.NativeFieldInfoPtr_m_Arrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_m_Arrows;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_DepthPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_DepthNormalsPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_MotionVectorsPass_Private_Void_CommandBuffer_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_PrepareArrows_Private_Void_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C6 RID: 1990
		public static class Uniforms : Object
		{
			// Token: 0x0600BAEF RID: 47855 RVA: 0x002E48E0 File Offset: 0x002E2AE0
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr);
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_DepthScale");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_TempRT");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Opacity");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_MainTex");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_TempRT2");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Amplitude");
				BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.Uniforms>.NativeClassPtr, "_Scale");
			}

			// Token: 0x0600BAF0 RID: 47856 RVA: 0x0005B7EB File Offset: 0x000599EB
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039C3 RID: 14787
			// (get) Token: 0x0600BAF1 RID: 47857 RVA: 0x002E4998 File Offset: 0x002E2B98
			// (set) Token: 0x0600BAF2 RID: 47858 RVA: 0x0005B7F4 File Offset: 0x000599F4
			public unsafe static int _DepthScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__DepthScale, (void*)(&value));
				}
			}

			// Token: 0x170039C4 RID: 14788
			// (get) Token: 0x0600BAF3 RID: 47859 RVA: 0x002E49B4 File Offset: 0x002E2BB4
			// (set) Token: 0x0600BAF4 RID: 47860 RVA: 0x0005B802 File Offset: 0x00059A02
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x170039C5 RID: 14789
			// (get) Token: 0x0600BAF5 RID: 47861 RVA: 0x002E49D0 File Offset: 0x002E2BD0
			// (set) Token: 0x0600BAF6 RID: 47862 RVA: 0x0005B810 File Offset: 0x00059A10
			public unsafe static int _Opacity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Opacity, (void*)(&value));
				}
			}

			// Token: 0x170039C6 RID: 14790
			// (get) Token: 0x0600BAF7 RID: 47863 RVA: 0x002E49EC File Offset: 0x002E2BEC
			// (set) Token: 0x0600BAF8 RID: 47864 RVA: 0x0005B81E File Offset: 0x00059A1E
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039C7 RID: 14791
			// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x002E4A08 File Offset: 0x002E2C08
			// (set) Token: 0x0600BAFA RID: 47866 RVA: 0x0005B82C File Offset: 0x00059A2C
			public unsafe static int _TempRT2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__TempRT2, (void*)(&value));
				}
			}

			// Token: 0x170039C8 RID: 14792
			// (get) Token: 0x0600BAFB RID: 47867 RVA: 0x002E4A24 File Offset: 0x002E2C24
			// (set) Token: 0x0600BAFC RID: 47868 RVA: 0x0005B83A File Offset: 0x00059A3A
			public unsafe static int _Amplitude
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Amplitude, (void*)(&value));
				}
			}

			// Token: 0x170039C9 RID: 14793
			// (get) Token: 0x0600BAFD RID: 47869 RVA: 0x002E4A40 File Offset: 0x002E2C40
			// (set) Token: 0x0600BAFE RID: 47870 RVA: 0x0005B848 File Offset: 0x00059A48
			public unsafe static int _Scale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuiltinDebugViewsComponent.Uniforms.NativeFieldInfoPtr__Scale, (void*)(&value));
				}
			}

			// Token: 0x04007E0B RID: 32267
			private static readonly IntPtr NativeFieldInfoPtr__DepthScale;

			// Token: 0x04007E0C RID: 32268
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;

			// Token: 0x04007E0D RID: 32269
			private static readonly IntPtr NativeFieldInfoPtr__Opacity;

			// Token: 0x04007E0E RID: 32270
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E0F RID: 32271
			private static readonly IntPtr NativeFieldInfoPtr__TempRT2;

			// Token: 0x04007E10 RID: 32272
			private static readonly IntPtr NativeFieldInfoPtr__Amplitude;

			// Token: 0x04007E11 RID: 32273
			private static readonly IntPtr NativeFieldInfoPtr__Scale;
		}

		// Token: 0x020007C7 RID: 1991
		[OriginalName("Assembly-CSharp.dll", "", "Pass")]
		public enum Pass
		{
			// Token: 0x04007E13 RID: 32275
			Depth,
			// Token: 0x04007E14 RID: 32276
			Normals,
			// Token: 0x04007E15 RID: 32277
			MovecOpacity,
			// Token: 0x04007E16 RID: 32278
			MovecImaging,
			// Token: 0x04007E17 RID: 32279
			MovecArrows
		}

		// Token: 0x020007C8 RID: 1992
		public class ArrowArray : Object
		{
			// Token: 0x0600BAFF RID: 47871 RVA: 0x002E4A5C File Offset: 0x002E2C5C
			// Note: this type is marked as 'beforefieldinit'.
			static ArrowArray()
			{
				Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuiltinDebugViewsComponent>.NativeClassPtr, "ArrowArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr);
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<mesh>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<columnCount>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, "<rowCount>k__BackingField");
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663900);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663901);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663902);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663903);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663904);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663905);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663906);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663907);
				BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr, 100663908);
			}

			// Token: 0x170039CD RID: 14797
			// (get) Token: 0x0600BB00 RID: 47872 RVA: 0x002E4B78 File Offset: 0x002E2D78
			// (set) Token: 0x0600BB01 RID: 47873 RVA: 0x002E4BB8 File Offset: 0x002E2DB8
			public unsafe Mesh mesh
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170039CE RID: 14798
			// (get) Token: 0x0600BB02 RID: 47874 RVA: 0x002E4BFC File Offset: 0x002E2DFC
			// (set) Token: 0x0600BB03 RID: 47875 RVA: 0x002E4C38 File Offset: 0x002E2E38
			public unsafe int columnCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29996, RefRangeEnd = 29998, XrefRangeStart = 29996, XrefRangeEnd = 29998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170039CF RID: 14799
			// (get) Token: 0x0600BB04 RID: 47876 RVA: 0x002E4C78 File Offset: 0x002E2E78
			// (set) Token: 0x0600BB05 RID: 47877 RVA: 0x002E4CB4 File Offset: 0x002E2EB4
			public unsafe int rowCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 41635, RefRangeEnd = 41636, XrefRangeStart = 41635, XrefRangeEnd = 41636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BB06 RID: 47878 RVA: 0x002E4CF4 File Offset: 0x002E2EF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76069, RefRangeEnd = 76071, XrefRangeStart = 76035, XrefRangeEnd = 76069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BuildMesh(int columns, int rows)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref columns;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rows;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB07 RID: 47879 RVA: 0x002E4D40 File Offset: 0x002E2F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76071, XrefRangeEnd = 76073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB08 RID: 47880 RVA: 0x002E4D74 File Offset: 0x002E2F74
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArrowArray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinDebugViewsComponent.ArrowArray>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinDebugViewsComponent.ArrowArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB09 RID: 47881 RVA: 0x0005B856 File Offset: 0x00059A56
			public ArrowArray(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039CA RID: 14794
			// (get) Token: 0x0600BB0A RID: 47882 RVA: 0x002E4DB0 File Offset: 0x002E2FB0
			// (set) Token: 0x0600BB0B RID: 47883 RVA: 0x0005B85F File Offset: 0x00059A5F
			public unsafe Mesh _mesh_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039CB RID: 14795
			// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x002E4DE0 File Offset: 0x002E2FE0
			// (set) Token: 0x0600BB0D RID: 47885 RVA: 0x0005B87E File Offset: 0x00059A7E
			public unsafe int _columnCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__columnCount_k__BackingField)) = value;
				}
			}

			// Token: 0x170039CC RID: 14796
			// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x002E4E08 File Offset: 0x002E3008
			// (set) Token: 0x0600BB0F RID: 47887 RVA: 0x0005B899 File Offset: 0x00059A99
			public unsafe int _rowCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuiltinDebugViewsComponent.ArrowArray.NativeFieldInfoPtr__rowCount_k__BackingField)) = value;
				}
			}

			// Token: 0x04007E18 RID: 32280
			private static readonly IntPtr NativeFieldInfoPtr__mesh_k__BackingField;

			// Token: 0x04007E19 RID: 32281
			private static readonly IntPtr NativeFieldInfoPtr__columnCount_k__BackingField;

			// Token: 0x04007E1A RID: 32282
			private static readonly IntPtr NativeFieldInfoPtr__rowCount_k__BackingField;

			// Token: 0x04007E1B RID: 32283
			private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

			// Token: 0x04007E1C RID: 32284
			private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Private_set_Void_Mesh_0;

			// Token: 0x04007E1D RID: 32285
			private static readonly IntPtr NativeMethodInfoPtr_get_columnCount_Public_get_Int32_0;

			// Token: 0x04007E1E RID: 32286
			private static readonly IntPtr NativeMethodInfoPtr_set_columnCount_Private_set_Void_Int32_0;

			// Token: 0x04007E1F RID: 32287
			private static readonly IntPtr NativeMethodInfoPtr_get_rowCount_Public_get_Int32_0;

			// Token: 0x04007E20 RID: 32288
			private static readonly IntPtr NativeMethodInfoPtr_set_rowCount_Private_set_Void_Int32_0;

			// Token: 0x04007E21 RID: 32289
			private static readonly IntPtr NativeMethodInfoPtr_BuildMesh_Public_Void_Int32_Int32_0;

			// Token: 0x04007E22 RID: 32290
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

			// Token: 0x04007E23 RID: 32291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
