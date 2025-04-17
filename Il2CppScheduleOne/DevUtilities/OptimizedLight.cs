using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045F RID: 1119
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x0600612F RID: 24879 RVA: 0x001BB934 File Offset: 0x001B9B34
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedLight()
		{
			Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OptimizedLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr);
			OptimizedLight.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "Enabled");
			OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "DisabledForOptimization");
			OptimizedLight.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "MaxDistance");
			OptimizedLight.NativeFieldInfoPtr__Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_Light");
			OptimizedLight.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "culled");
			OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "maxDistanceSquared");
			OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675651);
			OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675652);
			OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675653);
			OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675654);
			OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675655);
			OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675656);
			OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675657);
			OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675658);
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x001BBA7C File Offset: 0x001B9C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200367, XrefRangeEnd = 200371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x001BBAB8 File Offset: 0x001B9CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200371, XrefRangeEnd = 200395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x001BBAEC File Offset: 0x001B9CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200395, XrefRangeEnd = 200409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x001BBB20 File Offset: 0x001B9D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200409, XrefRangeEnd = 200415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x001BBB5C File Offset: 0x001B9D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200415, XrefRangeEnd = 200431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x001BBB90 File Offset: 0x001B9D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x001BBBD0 File Offset: 0x001B9DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200431, XrefRangeEnd = 200432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x001BBC0C File Offset: 0x001B9E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200473, RefRangeEnd = 200474, XrefRangeStart = 200432, XrefRangeEnd = 200473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x0002DEE2 File Offset: 0x0002C0E2
		public OptimizedLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06006139 RID: 24889 RVA: 0x001BBC40 File Offset: 0x001B9E40
		// (set) Token: 0x0600613A RID: 24890 RVA: 0x0002DEEB File Offset: 0x0002C0EB
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x0600613B RID: 24891 RVA: 0x001BBC68 File Offset: 0x001B9E68
		// (set) Token: 0x0600613C RID: 24892 RVA: 0x0002DF06 File Offset: 0x0002C106
		public unsafe bool DisabledForOptimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization)) = value;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x001BBC90 File Offset: 0x001B9E90
		// (set) Token: 0x0600613E RID: 24894 RVA: 0x0002DF21 File Offset: 0x0002C121
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x001BBCB8 File Offset: 0x001B9EB8
		// (set) Token: 0x06006140 RID: 24896 RVA: 0x0002DF3C File Offset: 0x0002C13C
		public unsafe Light _Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x001BBCE8 File Offset: 0x001B9EE8
		// (set) Token: 0x06006142 RID: 24898 RVA: 0x0002DF5B File Offset: 0x0002C15B
		public unsafe bool culled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled)) = value;
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06006143 RID: 24899 RVA: 0x001BBD10 File Offset: 0x001B9F10
		// (set) Token: 0x06006144 RID: 24900 RVA: 0x0002DF76 File Offset: 0x0002C176
		public unsafe float maxDistanceSquared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared)) = value;
			}
		}

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeFieldInfoPtr_DisabledForOptimization;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeFieldInfoPtr__Light;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeFieldInfoPtr_culled;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceSquared;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_1;

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
