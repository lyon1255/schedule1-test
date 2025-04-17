using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000049 RID: 73
	public class ResetPosition : MonoBehaviour
	{
		// Token: 0x06000617 RID: 1559 RVA: 0x00082754 File Offset: 0x00080954
		// Note: this type is marked as 'beforefieldinit'.
		static ResetPosition()
		{
			Il2CppClassPointerStore<ResetPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResetPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr);
			ResetPosition.NativeFieldInfoPtr_distanceToReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "distanceToReset");
			ResetPosition.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, "startPosition");
			ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663866);
			ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663867);
			ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr, 100663868);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000827E8 File Offset: 0x000809E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0008281C File Offset: 0x00080A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75754, XrefRangeEnd = 75763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00082850 File Offset: 0x00080A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75763, XrefRangeEnd = 75764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResetPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResetPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00005979 File Offset: 0x00003B79
		public ResetPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0008288C File Offset: 0x00080A8C
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00005982 File Offset: 0x00003B82
		public unsafe float distanceToReset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_distanceToReset)) = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x000828B4 File Offset: 0x00080AB4
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0000599D File Offset: 0x00003B9D
		public unsafe Vector3 startPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResetPosition.NativeFieldInfoPtr_startPosition)) = value;
			}
		}

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_distanceToReset;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_startPosition;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
