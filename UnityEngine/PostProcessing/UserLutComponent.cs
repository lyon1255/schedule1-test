using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005D RID: 93
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00086064 File Offset: 0x00084264
		// Note: this type is marked as 'beforefieldinit'.
		static UserLutComponent()
		{
			Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "UserLutComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr);
			UserLutComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664028);
			UserLutComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664029);
			UserLutComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664030);
			UserLutComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, 100664031);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000860E4 File Offset: 0x000842E4
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77683, XrefRangeEnd = 77690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00086120 File Offset: 0x00084320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77690, XrefRangeEnd = 77701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00086164 File Offset: 0x00084364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77701, XrefRangeEnd = 77708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr_OnGUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00086198 File Offset: 0x00084398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77708, XrefRangeEnd = 77711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserLutComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserLutComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00005FAF File Offset: 0x000041AF
		public UserLutComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Public_Void_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D8 RID: 2008
		public static class Uniforms : Object
		{
			// Token: 0x0600BC2D RID: 48173 RVA: 0x002E6C2C File Offset: 0x002E4E2C
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserLutComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr);
				UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr, "_UserLut");
				UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserLutComponent.Uniforms>.NativeClassPtr, "_UserLut_Params");
			}

			// Token: 0x0600BC2E RID: 48174 RVA: 0x0005C043 File Offset: 0x0005A243
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A4C RID: 14924
			// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x002E6C80 File Offset: 0x002E4E80
			// (set) Token: 0x0600BC30 RID: 48176 RVA: 0x0005C04C File Offset: 0x0005A24C
			public unsafe static int _UserLut
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut, (void*)(&value));
				}
			}

			// Token: 0x17003A4D RID: 14925
			// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x002E6C9C File Offset: 0x002E4E9C
			// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x0005C05A File Offset: 0x0005A25A
			public unsafe static int _UserLut_Params
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UserLutComponent.Uniforms.NativeFieldInfoPtr__UserLut_Params, (void*)(&value));
				}
			}

			// Token: 0x04007EBF RID: 32447
			private static readonly IntPtr NativeFieldInfoPtr__UserLut;

			// Token: 0x04007EC0 RID: 32448
			private static readonly IntPtr NativeFieldInfoPtr__UserLut_Params;
		}
	}
}
