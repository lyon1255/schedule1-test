using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065F RID: 1631
	public class PropagateDrag : MonoBehaviour
	{
		// Token: 0x060091AF RID: 37295 RVA: 0x00259D98 File Offset: 0x00257F98
		// Note: this type is marked as 'beforefieldinit'.
		static PropagateDrag()
		{
			Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropagateDrag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr);
			PropagateDrag.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, "ScrollView");
			PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681352);
			PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681353);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681354);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681355);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681356);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681357);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100681358);
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00259E68 File Offset: 0x00258068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263230, XrefRangeEnd = 263313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x00259E9C File Offset: 0x0025809C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagateDrag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x00259ED8 File Offset: 0x002580D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263313, XrefRangeEnd = 263317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x00259F1C File Offset: 0x0025811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263317, XrefRangeEnd = 263321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00259F60 File Offset: 0x00258160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263321, XrefRangeEnd = 263325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_2(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00259FA4 File Offset: 0x002581A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263325, XrefRangeEnd = 263329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_3(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00259FE8 File Offset: 0x002581E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263329, XrefRangeEnd = 263333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_4(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00046766 File Offset: 0x00044966
		public PropagateDrag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x0025A02C File Offset: 0x0025822C
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x0004676F File Offset: 0x0004496F
		public unsafe ScrollRect ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006270 RID: 25200
		private static readonly IntPtr NativeFieldInfoPtr_ScrollView;

		// Token: 0x04006271 RID: 25201
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006272 RID: 25202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006273 RID: 25203
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0;

		// Token: 0x04006274 RID: 25204
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0;

		// Token: 0x04006275 RID: 25205
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0;

		// Token: 0x04006276 RID: 25206
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0;

		// Token: 0x04006277 RID: 25207
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0;
	}
}
