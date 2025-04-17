using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000155 RID: 341
	public class CharacterPreBuilt : ScriptableObject
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x000C7264 File Offset: 0x000C5464
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterPreBuilt()
		{
			Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterPreBuilt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr);
			CharacterPreBuilt.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr, "settings");
			CharacterPreBuilt.NativeFieldInfoPtr_preBuiltDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr, "preBuiltDatas");
			CharacterPreBuilt.NativeFieldInfoPtr_blendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr, "blendshapes");
			CharacterPreBuilt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr, 100666236);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000C72E4 File Offset: 0x000C54E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100500, XrefRangeEnd = 100515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterPreBuilt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPreBuilt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterPreBuilt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0000FC07 File Offset: 0x0000DE07
		public CharacterPreBuilt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000C7320 File Offset: 0x000C5520
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000FC10 File Offset: 0x0000DE10
		public unsafe CharacterSettings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000C7350 File Offset: 0x000C5550
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x0000FC2F File Offset: 0x0000DE2F
		public unsafe List<PreBuiltData> preBuiltDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_preBuiltDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PreBuiltData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_preBuiltDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000C7380 File Offset: 0x000C5580
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x0000FC4E File Offset: 0x0000DE4E
		public unsafe List<PreBuiltBlendshape> blendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_blendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PreBuiltBlendshape>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterPreBuilt.NativeFieldInfoPtr_blendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeFieldInfoPtr_preBuiltDatas;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeFieldInfoPtr_blendshapes;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
