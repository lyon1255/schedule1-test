using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000637 RID: 1591
	public class EyeLidOverlaySetter : MonoBehaviour
	{
		// Token: 0x06008CA2 RID: 36002 RVA: 0x0024B2BC File Offset: 0x002494BC
		// Note: this type is marked as 'beforefieldinit'.
		static EyeLidOverlaySetter()
		{
			Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyeLidOverlaySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr);
			EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, "OpenOverride");
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680759);
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680760);
			EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680761);
			EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100680762);
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x0024B350 File Offset: 0x00249550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256772, XrefRangeEnd = 256776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x0024B384 File Offset: 0x00249584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256776, XrefRangeEnd = 256780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x0024B3B8 File Offset: 0x002495B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256780, XrefRangeEnd = 256786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x0024B3EC File Offset: 0x002495EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeLidOverlaySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x0004374C File Offset: 0x0004194C
		public EyeLidOverlaySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x06008CA8 RID: 36008 RVA: 0x0024B428 File Offset: 0x00249628
		// (set) Token: 0x06008CA9 RID: 36009 RVA: 0x00043755 File Offset: 0x00041955
		public unsafe float OpenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride)) = value;
			}
		}

		// Token: 0x04005F4E RID: 24398
		private static readonly IntPtr NativeFieldInfoPtr_OpenOverride;

		// Token: 0x04005F4F RID: 24399
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005F50 RID: 24400
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04005F51 RID: 24401
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F52 RID: 24402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
