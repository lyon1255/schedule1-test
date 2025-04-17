using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000024 RID: 36
	public class ModifySkyAtRuntime : MonoBehaviour
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00078E94 File Offset: 0x00077094
		// Note: this type is marked as 'beforefieldinit'.
		static ModifySkyAtRuntime()
		{
			Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModifySkyAtRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr);
			ModifySkyAtRuntime.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, "speed");
			ModifySkyAtRuntime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, 100663554);
			ModifySkyAtRuntime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr, 100663555);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00078F00 File Offset: 0x00077100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72735, XrefRangeEnd = 72758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifySkyAtRuntime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00078F34 File Offset: 0x00077134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72758, XrefRangeEnd = 72759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModifySkyAtRuntime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifySkyAtRuntime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModifySkyAtRuntime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000387B File Offset: 0x00001A7B
		public ModifySkyAtRuntime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00078F70 File Offset: 0x00077170
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00003884 File Offset: 0x00001A84
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifySkyAtRuntime.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModifySkyAtRuntime.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
