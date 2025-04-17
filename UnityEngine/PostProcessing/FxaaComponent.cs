using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000058 RID: 88
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00084F60 File Offset: 0x00083160
		// Note: this type is marked as 'beforefieldinit'.
		static FxaaComponent()
		{
			Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "FxaaComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr);
			FxaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663970);
			FxaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663971);
			FxaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, 100663972);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00084FCC File Offset: 0x000831CC
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76907, XrefRangeEnd = 76908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00085008 File Offset: 0x00083208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76931, RefRangeEnd = 76932, XrefRangeStart = 76908, XrefRangeEnd = 76931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0008505C File Offset: 0x0008325C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76932, XrefRangeEnd = 76935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FxaaComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FxaaComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public FxaaComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_RenderTexture_RenderTexture_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CF RID: 1999
		public static class Uniforms : Object
		{
			// Token: 0x0600BB78 RID: 47992 RVA: 0x002E57D8 File Offset: 0x002E39D8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FxaaComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr);
				FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr, "_QualitySettings");
				FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FxaaComponent.Uniforms>.NativeClassPtr, "_ConsoleSettings");
			}

			// Token: 0x0600BB79 RID: 47993 RVA: 0x0005BB6E File Offset: 0x00059D6E
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039FE RID: 14846
			// (get) Token: 0x0600BB7A RID: 47994 RVA: 0x002E582C File Offset: 0x002E3A2C
			// (set) Token: 0x0600BB7B RID: 47995 RVA: 0x0005BB77 File Offset: 0x00059D77
			public unsafe static int _QualitySettings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__QualitySettings, (void*)(&value));
				}
			}

			// Token: 0x170039FF RID: 14847
			// (get) Token: 0x0600BB7C RID: 47996 RVA: 0x002E5848 File Offset: 0x002E3A48
			// (set) Token: 0x0600BB7D RID: 47997 RVA: 0x0005BB85 File Offset: 0x00059D85
			public unsafe static int _ConsoleSettings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FxaaComponent.Uniforms.NativeFieldInfoPtr__ConsoleSettings, (void*)(&value));
				}
			}

			// Token: 0x04007E52 RID: 32338
			private static readonly IntPtr NativeFieldInfoPtr__QualitySettings;

			// Token: 0x04007E53 RID: 32339
			private static readonly IntPtr NativeFieldInfoPtr__ConsoleSettings;
		}
	}
}
