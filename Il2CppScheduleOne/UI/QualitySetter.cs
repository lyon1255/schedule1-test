using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000622 RID: 1570
	public class QualitySetter : MonoBehaviour
	{
		// Token: 0x06008A6D RID: 35437 RVA: 0x0024470C File Offset: 0x0024290C
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySetter()
		{
			Il2CppClassPointerStore<QualitySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "QualitySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr);
			QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680495);
			QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680496);
			QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680497);
			QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100680498);
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0024478C File Offset: 0x0024298C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254057, XrefRangeEnd = 254070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x002447C0 File Offset: 0x002429C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254070, XrefRangeEnd = 254079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x00244800 File Offset: 0x00242A00
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualitySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x0024483C File Offset: 0x00242A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254079, XrefRangeEnd = 254088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__0_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x00042387 File Offset: 0x00040587
		public QualitySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005DE8 RID: 24040
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005DE9 RID: 24041
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0;

		// Token: 0x04005DEA RID: 24042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005DEB RID: 24043
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0;
	}
}
