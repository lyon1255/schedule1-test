using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000057 RID: 87
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x00084D18 File Offset: 0x00082F18
		// Note: this type is marked as 'beforefieldinit'.
		static FogComponent()
		{
			Il2CppClassPointerStore<FogComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FogComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogComponent>.NativeClassPtr);
			FogComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, "k_ShaderString");
			FogComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663963);
			FogComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663964);
			FogComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663965);
			FogComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663966);
			FogComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663967);
			FogComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, 100663968);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00084DD4 File Offset: 0x00082FD4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76843, XrefRangeEnd = 76846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00084E10 File Offset: 0x00083010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76846, XrefRangeEnd = 76848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00084E48 File Offset: 0x00083048
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00084E84 File Offset: 0x00083084
		[CallerCount(0)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00084EC0 File Offset: 0x000830C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76848, XrefRangeEnd = 76904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00084F04 File Offset: 0x00083104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76904, XrefRangeEnd = 76907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FogComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FogComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FogComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00005DB5 File Offset: 0x00003FB5
		public FogComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00084F40 File Offset: 0x00083140
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00005DBE File Offset: 0x00003FBE
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FogComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FogComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CE RID: 1998
		public static class Uniforms : Object
		{
			// Token: 0x0600BB6C RID: 47980 RVA: 0x002E56BC File Offset: 0x002E38BC
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FogComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr);
				FogComponent.Uniforms.NativeFieldInfoPtr__FogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_FogColor");
				FogComponent.Uniforms.NativeFieldInfoPtr__Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_Density");
				FogComponent.Uniforms.NativeFieldInfoPtr__Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_Start");
				FogComponent.Uniforms.NativeFieldInfoPtr__End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_End");
				FogComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FogComponent.Uniforms>.NativeClassPtr, "_TempRT");
			}

			// Token: 0x0600BB6D RID: 47981 RVA: 0x0005BB1F File Offset: 0x00059D1F
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039F9 RID: 14841
			// (get) Token: 0x0600BB6E RID: 47982 RVA: 0x002E574C File Offset: 0x002E394C
			// (set) Token: 0x0600BB6F RID: 47983 RVA: 0x0005BB28 File Offset: 0x00059D28
			public unsafe static int _FogColor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__FogColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__FogColor, (void*)(&value));
				}
			}

			// Token: 0x170039FA RID: 14842
			// (get) Token: 0x0600BB70 RID: 47984 RVA: 0x002E5768 File Offset: 0x002E3968
			// (set) Token: 0x0600BB71 RID: 47985 RVA: 0x0005BB36 File Offset: 0x00059D36
			public unsafe static int _Density
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__Density, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__Density, (void*)(&value));
				}
			}

			// Token: 0x170039FB RID: 14843
			// (get) Token: 0x0600BB72 RID: 47986 RVA: 0x002E5784 File Offset: 0x002E3984
			// (set) Token: 0x0600BB73 RID: 47987 RVA: 0x0005BB44 File Offset: 0x00059D44
			public unsafe static int _Start
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__Start, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__Start, (void*)(&value));
				}
			}

			// Token: 0x170039FC RID: 14844
			// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x002E57A0 File Offset: 0x002E39A0
			// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x0005BB52 File Offset: 0x00059D52
			public unsafe static int _End
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__End, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__End, (void*)(&value));
				}
			}

			// Token: 0x170039FD RID: 14845
			// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x002E57BC File Offset: 0x002E39BC
			// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x0005BB60 File Offset: 0x00059D60
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FogComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FogComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x04007E4D RID: 32333
			private static readonly IntPtr NativeFieldInfoPtr__FogColor;

			// Token: 0x04007E4E RID: 32334
			private static readonly IntPtr NativeFieldInfoPtr__Density;

			// Token: 0x04007E4F RID: 32335
			private static readonly IntPtr NativeFieldInfoPtr__Start;

			// Token: 0x04007E50 RID: 32336
			private static readonly IntPtr NativeFieldInfoPtr__End;

			// Token: 0x04007E51 RID: 32337
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;
		}
	}
}
