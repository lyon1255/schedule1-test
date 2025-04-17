using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000AD RID: 173
	public class SkewingHandleSD : MonoBehaviour
	{
		// Token: 0x06000C17 RID: 3095 RVA: 0x00097408 File Offset: 0x00095608
		// Note: this type is marked as 'beforefieldinit'.
		static SkewingHandleSD()
		{
			Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "SkewingHandleSD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr);
			SkewingHandleSD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "ClassName");
			SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "volumetricLightBeam");
			SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "shouldUpdateEachFrame");
			SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664774);
			SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664775);
			SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664776);
			SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664777);
			SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664778);
			SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664779);
			SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664780);
			SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664781);
			SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, 100664782);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00097528 File Offset: 0x00095728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83919, XrefRangeEnd = 83923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAttachedToSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00097564 File Offset: 0x00095764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 83927, RefRangeEnd = 83931, XrefRangeStart = 83923, XrefRangeEnd = 83927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000975A0 File Offset: 0x000957A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83931, XrefRangeEnd = 83932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000975DC File Offset: 0x000957DC
		[CallerCount(0)]
		public unsafe bool ShouldUpdateEachFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00097618 File Offset: 0x00095818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83932, XrefRangeEnd = 83934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0009764C File Offset: 0x0009584C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83934, XrefRangeEnd = 83945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00097680 File Offset: 0x00095880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83945, XrefRangeEnd = 83950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000976C0 File Offset: 0x000958C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83954, RefRangeEnd = 83956, XrefRangeStart = 83950, XrefRangeEnd = 83954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkewingVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr_SetSkewingVector_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000976F4 File Offset: 0x000958F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkewingHandleSD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00007FF9 File Offset: 0x000061F9
		public SkewingHandleSD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x00097730 File Offset: 0x00095930
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00008002 File Offset: 0x00006202
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkewingHandleSD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00097750 File Offset: 0x00095950
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00008014 File Offset: 0x00006214
		public unsafe VolumetricLightBeamSD volumetricLightBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_volumetricLightBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00097780 File Offset: 0x00095980
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x00008033 File Offset: 0x00006233
		public unsafe bool shouldUpdateEachFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD.NativeFieldInfoPtr_shouldUpdateEachFrame)) = value;
			}
		}

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr_volumetricLightBeam;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_shouldUpdateEachFrame;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_IsAttachedToSelf_Public_Boolean_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_CanSetSkewingVector_Public_Boolean_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_CanUpdateEachFrame_Public_Boolean_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUpdateEachFrame_Private_Boolean_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_SetSkewingVector_Private_Void_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000833 RID: 2099
		[ObfuscatedName("VLB.SkewingHandleSD+<CoUpdate>d__9")]
		public sealed class _CoUpdate_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600BEED RID: 48877 RVA: 0x002ED69C File Offset: 0x002EB89C
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__9()
			{
				Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkewingHandleSD>.NativeClassPtr, "<CoUpdate>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr);
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>1__state");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>2__current");
				SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, "<>4__this");
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664783);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664784);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664785);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664786);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664787);
				SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr, 100664788);
			}

			// Token: 0x0600BEEE RID: 48878 RVA: 0x002ED77C File Offset: 0x002EB97C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkewingHandleSD._CoUpdate_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEEF RID: 48879 RVA: 0x002ED7C4 File Offset: 0x002EB9C4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEF0 RID: 48880 RVA: 0x002ED7F8 File Offset: 0x002EB9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83911, XrefRangeEnd = 83914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B61 RID: 15201
			// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x002ED834 File Offset: 0x002EBA34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEF2 RID: 48882 RVA: 0x002ED874 File Offset: 0x002EBA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83914, XrefRangeEnd = 83919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B62 RID: 15202
			// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x002ED8A8 File Offset: 0x002EBAA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkewingHandleSD._CoUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEF4 RID: 48884 RVA: 0x0005D563 File Offset: 0x0005B763
			public _CoUpdate_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B5E RID: 15198
			// (get) Token: 0x0600BEF5 RID: 48885 RVA: 0x002ED8E8 File Offset: 0x002EBAE8
			// (set) Token: 0x0600BEF6 RID: 48886 RVA: 0x0005D56C File Offset: 0x0005B76C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B5F RID: 15199
			// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x002ED910 File Offset: 0x002EBB10
			// (set) Token: 0x0600BEF8 RID: 48888 RVA: 0x0005D587 File Offset: 0x0005B787
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B60 RID: 15200
			// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x002ED940 File Offset: 0x002EBB40
			// (set) Token: 0x0600BEFA RID: 48890 RVA: 0x0005D5A6 File Offset: 0x0005B7A6
			public unsafe SkewingHandleSD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkewingHandleSD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkewingHandleSD._CoUpdate_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400816B RID: 33131
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400816C RID: 33132
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400816D RID: 33133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400816E RID: 33134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400816F RID: 33135
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008170 RID: 33136
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008171 RID: 33137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008172 RID: 33138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008173 RID: 33139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
