using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000014 RID: 20
	public class CircularTextMeshPro : MonoBehaviour
	{
		// Token: 0x06000163 RID: 355 RVA: 0x00074FE8 File Offset: 0x000731E8
		// Note: this type is marked as 'beforefieldinit'.
		static CircularTextMeshPro()
		{
			Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CircularTextMeshPro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr);
			CircularTextMeshPro.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "text");
			CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "vertexCurve");
			CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "yCurveScaling");
			CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, "isForceUpdatingMesh");
			CircularTextMeshPro.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663411);
			CircularTextMeshPro.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663412);
			CircularTextMeshPro.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663413);
			CircularTextMeshPro.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663414);
			CircularTextMeshPro.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663415);
			CircularTextMeshPro.NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663416);
			CircularTextMeshPro.NativeMethodInfoPtr_WarpText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663417);
			CircularTextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00075108 File Offset: 0x00073308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71902, XrefRangeEnd = 71908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0007513C File Offset: 0x0007333C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71908, XrefRangeEnd = 71917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00075170 File Offset: 0x00073370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71917, XrefRangeEnd = 71932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000751A4 File Offset: 0x000733A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71932, XrefRangeEnd = 71946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000751D8 File Offset: 0x000733D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71946, XrefRangeEnd = 71947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0007520C File Offset: 0x0007340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71947, XrefRangeEnd = 71962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReactToTextChanged(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00075250 File Offset: 0x00073450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71984, RefRangeEnd = 71987, XrefRangeStart = 71962, XrefRangeEnd = 71984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr_WarpText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00075284 File Offset: 0x00073484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71987, XrefRangeEnd = 71999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircularTextMeshPro() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularTextMeshPro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularTextMeshPro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002C8C File Offset: 0x00000E8C
		public CircularTextMeshPro(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000752C0 File Offset: 0x000734C0
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00002C95 File Offset: 0x00000E95
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000752F0 File Offset: 0x000734F0
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public unsafe AnimationCurve vertexCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_vertexCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00075320 File Offset: 0x00073520
		// (set) Token: 0x06000172 RID: 370 RVA: 0x00002CD3 File Offset: 0x00000ED3
		public unsafe float yCurveScaling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_yCurveScaling)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00075348 File Offset: 0x00073548
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00002CEE File Offset: 0x00000EEE
		public unsafe bool isForceUpdatingMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularTextMeshPro.NativeFieldInfoPtr_isForceUpdatingMesh)) = value;
			}
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_vertexCurve;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_yCurveScaling;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_isForceUpdatingMesh;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_ReactToTextChanged_Private_Void_Object_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_WarpText_Private_Void_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
