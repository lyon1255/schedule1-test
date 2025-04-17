using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000DD RID: 221
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		// Token: 0x060011E9 RID: 4585 RVA: 0x000A8BA8 File Offset: 0x000A6DA8
		// Note: this type is marked as 'beforefieldinit'.
		static NearbyStarRenderer()
		{
			Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NearbyStarRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr);
			NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kMaxStars");
			NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kStarPointTextureWidth");
			NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "kStarPaddingRadiusMultipler");
			NearbyStarRenderer.NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665351);
			NearbyStarRenderer.NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665352);
			NearbyStarRenderer.NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665353);
			NearbyStarRenderer.NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665354);
			NearbyStarRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665355);
			NearbyStarRenderer.NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665356);
			NearbyStarRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, 100665357);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000A8CA0 File Offset: 0x000A6EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88840, XrefRangeEnd = 88844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderTextureSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000A8D0C File Offset: 0x000A6F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88844, XrefRangeEnd = 88867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref randomSeed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref starCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000A8D68 File Offset: 0x000A6F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88867, XrefRangeEnd = 88870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDebugTexture(RenderTexture rt, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000A8DBC File Offset: 0x000A6FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88894, RefRangeEnd = 88895, XrefRangeStart = 88870, XrefRangeEnd = 88894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(starTexKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &validStarPixelCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000A8E1C File Offset: 0x000A701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88895, XrefRangeEnd = 88900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator ComputeStarData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NearbyStarRenderer.NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000A8E68 File Offset: 0x000A7068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88909, RefRangeEnd = 88911, XrefRangeStart = 88900, XrefRangeEnd = 88909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000A8EB8 File Offset: 0x000A70B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88911, XrefRangeEnd = 88912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NearbyStarRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000AE30 File Offset: 0x00009030
		public NearbyStarRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x000A8EF4 File Offset: 0x000A70F4
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000AE39 File Offset: 0x00009039
		public unsafe static int kMaxStars
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kMaxStars, (void*)(&value));
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000A8F10 File Offset: 0x000A7110
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000AE47 File Offset: 0x00009047
		public unsafe static int kStarPointTextureWidth
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPointTextureWidth, (void*)(&value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000A8F2C File Offset: 0x000A712C
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000AE55 File Offset: 0x00009055
		public unsafe static float kStarPaddingRadiusMultipler
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NearbyStarRenderer.NativeFieldInfoPtr_kStarPaddingRadiusMultipler, (void*)(&value));
			}
		}

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_kMaxStars;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr_kStarPointTextureWidth;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_kStarPaddingRadiusMultipler;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderTexture_Private_RenderTexture_String_Int32_RenderTextureFormat_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_GetNearbyStarMaterial_Private_Material_Vector4_Int32_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_WriteDebugTexture_Private_Void_RenderTexture_String_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_GetStarListTexture_Private_Texture2D_String_byref_Int32_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStarData_Public_Virtual_IEnumerator_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToTexture2D_Private_Texture2D_RenderTexture_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084D RID: 2125
		[ObfuscatedName("Funly.SkyStudio.NearbyStarRenderer+<ComputeStarData>d__7")]
		public sealed class _ComputeStarData_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600C044 RID: 49220 RVA: 0x002F03C4 File Offset: 0x002EE5C4
			// Note: this type is marked as 'beforefieldinit'.
			static _ComputeStarData_d__7()
			{
				Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NearbyStarRenderer>.NativeClassPtr, "<ComputeStarData>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr);
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>1__state");
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>2__current");
				NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, "<>4__this");
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665358);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665359);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665360);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665361);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665362);
				NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr, 100665363);
			}

			// Token: 0x0600C045 RID: 49221 RVA: 0x002F04A4 File Offset: 0x002EE6A4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ComputeStarData_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NearbyStarRenderer._ComputeStarData_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C046 RID: 49222 RVA: 0x002F04EC File Offset: 0x002EE6EC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C047 RID: 49223 RVA: 0x002F0520 File Offset: 0x002EE720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88777, XrefRangeEnd = 88835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003BE6 RID: 15334
			// (get) Token: 0x0600C048 RID: 49224 RVA: 0x002F055C File Offset: 0x002EE75C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C049 RID: 49225 RVA: 0x002F059C File Offset: 0x002EE79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88835, XrefRangeEnd = 88840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003BE7 RID: 15335
			// (get) Token: 0x0600C04A RID: 49226 RVA: 0x002F05D0 File Offset: 0x002EE7D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NearbyStarRenderer._ComputeStarData_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C04B RID: 49227 RVA: 0x0005DEF5 File Offset: 0x0005C0F5
			public _ComputeStarData_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE3 RID: 15331
			// (get) Token: 0x0600C04C RID: 49228 RVA: 0x002F0610 File Offset: 0x002EE810
			// (set) Token: 0x0600C04D RID: 49229 RVA: 0x0005DEFE File Offset: 0x0005C0FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003BE4 RID: 15332
			// (get) Token: 0x0600C04E RID: 49230 RVA: 0x002F0638 File Offset: 0x002EE838
			// (set) Token: 0x0600C04F RID: 49231 RVA: 0x0005DF19 File Offset: 0x0005C119
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE5 RID: 15333
			// (get) Token: 0x0600C050 RID: 49232 RVA: 0x002F0668 File Offset: 0x002EE868
			// (set) Token: 0x0600C051 RID: 49233 RVA: 0x0005DF38 File Offset: 0x0005C138
			public unsafe NearbyStarRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NearbyStarRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NearbyStarRenderer._ComputeStarData_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400822D RID: 33325
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400822E RID: 33326
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400822F RID: 33327
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008230 RID: 33328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008231 RID: 33329
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008232 RID: 33330
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008233 RID: 33331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008234 RID: 33332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008235 RID: 33333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
